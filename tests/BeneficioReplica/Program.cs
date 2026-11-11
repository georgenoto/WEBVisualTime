using System.Globalization;
using System.Runtime.InteropServices;
using WEBVisualTime.Datos.ReplicaBeneficios;
using WEBVisualTime.Entidades.ReplicaBeneficios;
using static WEBVisualTime.Datos.ReplicaBeneficios.BeneficioSql;
NativeLibrary.SetDllImportResolver(typeof(Native).Assembly,(name,assembly,path)=>name=="sqlite3" ? NativeLibrary.Load(OperatingSystem.IsWindows()?"winsqlite3.dll":"libsqlite3.so.0"):IntPtr.Zero);
if(Native.Open(":memory:",out var db)!=0)throw new Exception("SQL fixture unavailable");
int checks=0;
void Check(bool yes,string text){if(!yes)throw new Exception(text);checks++;}
string Run(string sql,long start=0,long end=1000)
{
    sql=sql.Replace(" MINUS "," EXCEPT ").Replace(":startNo",start.ToString(CultureInfo.InvariantCulture)).Replace(":endNo",end.ToString(CultureInfo.InvariantCulture)).Replace(":usuario","77").Replace(":ramo","5").Replace(":producto","2").Replace(":id","'job'");
    string result="";
    Native.Callback cb=(_,n,v,names)=>{if(n>0)result=Marshal.PtrToStringUTF8(Marshal.ReadIntPtr(v))??"";return 0;};
    var code=Native.Exec(db,sql,cb,IntPtr.Zero,out var error);
    if(code!=0){var text=Marshal.PtrToStringUTF8(error);Native.Free(error);throw new Exception(text+" SQL: "+sql);}
    GC.KeepAlive(cb);return result;
}
long Count(string sql)=>long.Parse(Run(sql),CultureInfo.InvariantCulture);
var columns=Columns.Split(',');
void Add(int modulo,int cover=1,string amount="100",string expiry="NULL",int? prod=2)
{
    var values=columns.ToDictionary(c=>c,c=>c.StartsWith('S')?"'texto'":"1");
    values["NBRANCH"]="5"; values["NPRODUCT"]=prod!.Value.ToString(); values["NMODULEC"]=modulo.ToString(); values["NCOVER"]=cover.ToString();
    values["NAMOUNT_BENE"]=amount;values["DEFFECDATE"]="'2020-01-01'";values["DNULLDATE"]=expiry;values["DCOMPDATE"]="'2021-01-01'";
    Run($"INSERT INTO {Target}({Columns}) VALUES({string.Join(',',columns.Select(c=>values[c]))})");
}
try
{
    foreach(var invalid in new[]{new BeneficioPlan(5,2,5,[],1),new(5,2,5,[5],1),new(5,2,5,[10,10],1),new(5,2,5,[0],1),new(5,2,5,[10],0),new(6,2,5,[10],1)})
    {var rejected=false;try{invalid.Validar();}catch(ArgumentException){rejected=true;}Check(rejected,"Invalid plan rejected");}
    new BeneficioPlan(5,2,5,[10,15],77).Validar();
    Run("ATTACH DATABASE ':memory:' AS INSUDB");
    var def=string.Join(',',columns.Select(c=>c+" "+(c.StartsWith('S')||c.StartsWith('D')?"TEXT":"NUMERIC")));
    Run($"CREATE TABLE {Target}({def},PRIMARY KEY(NBRANCH,NPRODUCT,NMODULEC,DEFFECDATE,NCOVER,NIDMEDBENEF))");
    Run($"CREATE TABLE {Snapshot}(ID TEXT,TIPO TEXT,ITEM_NO INTEGER,{def},PRIMARY KEY(ID,TIPO,ITEM_NO))");
    Run($"CREATE TABLE {Stage}(ID TEXT,ITEM_NO INTEGER,{def},PRIMARY KEY(ID,ITEM_NO))");
    Run($"CREATE TABLE {Dest}(ID TEXT,NMODULEC INTEGER,ORDEN INTEGER); INSERT INTO {Dest} VALUES('job',10,1),('job',15,2)");
    Run($"CREATE TABLE {Jobs}(ID TEXT,FECHA_COPIA TEXT,PREPARADOS INTEGER,ESTADO TEXT,BASE_FILAS INTEGER);INSERT INTO {Jobs} VALUES('job','2026-11-10',0,'EN_COLA',2)");
    Add(5);Add(5,2,"200","'2023-01-01'");Add(10,1,"999");Add(20,1,"555");Add(10,1,"888",prod:3);
    Run($"INSERT INTO {Snapshot} SELECT 'job','BASE',ROW_NUMBER() OVER(ORDER BY NCOVER),{Columns} FROM {Target} WHERE NPRODUCT=2 AND NMODULEC=5");
    Run($"INSERT INTO {Snapshot} SELECT 'job','ANTES',ROW_NUMBER() OVER(ORDER BY NCOVER),{Columns} FROM {Target} WHERE NPRODUCT=2 AND NMODULEC=10");
    Run("BEGIN");Run(Prepare,0,2);Run($"UPDATE {Jobs} SET PREPARADOS=2");Run("COMMIT");
    Run("BEGIN");Run(Prepare,2,4);Run($"UPDATE {Jobs} SET PREPARADOS=4");Run("ROLLBACK");
    Check(Count($"SELECT COUNT(*) FROM {Stage}")==2&&Run($"SELECT PREPARADOS FROM {Jobs}")=="2","Failed segment and checkpoint roll back together");
    Run("BEGIN");Run(Prepare,2,4);Run($"UPDATE {Jobs} SET PREPARADOS=4");Run("COMMIT");
    Check(Count($"SELECT COUNT(*) FROM {Stage}")==4,"Resume prepares only remaining items");
    Check(Count($"SELECT COUNT(*) FROM {Stage} WHERE NUSERCODE=77 AND DCOMPDATE='2026-11-10'")==4,"Copy user and timestamp correctly aliased");
    Check(Count($"SELECT COUNT(*) FROM {Stage} WHERE DNULLDATE='2023-01-01'")==2,"Historical benefits preserved");
    Check(Count($"SELECT COUNT(*) FROM {Stage} WHERE NIDMEDBENEF=1 AND DEFFECDATE='2020-01-01'")==4,"Original IDs and effective dates preserved");
    Run("BEGIN");Run(Delete);Run(Insert(Stage,""));Run($"UPDATE {Jobs} SET ESTADO='COMPLETADO'");Run("ROLLBACK");
    Check(Run($"SELECT NAMOUNT_BENE FROM {Target} WHERE NPRODUCT=2 AND NMODULEC=10")=="999","Failed publication restores deleted configuration");
    Check(Run($"SELECT ESTADO FROM {Jobs}")=="EN_COLA","Failed publication does not commit completed status");
    Run("BEGIN");Run(Delete);Run(Insert(Stage,""));Run($"UPDATE {Jobs} SET ESTADO='COMPLETADO'");Run("COMMIT");
    Check(Count($"SELECT COUNT(*) FROM ({Selected})")==4,"All selected modules published");
    Check(Run($"SELECT NAMOUNT_BENE FROM {Target} WHERE NMODULEC=20")=="555","Unselected module preserved");
    Check(Run($"SELECT NAMOUNT_BENE FROM {Target} WHERE NPRODUCT=3")=="888","Other product preserved");
    Check(Count($"SELECT COUNT(*) FROM {Target} WHERE NMODULEC=5")==2,"Base preserved");
    var stageSelect=$"SELECT {Columns} FROM {Stage} WHERE ID=:id";
    Check(Count(Difference(Selected,stageSelect))==0&&Count(Difference(stageSelect,Selected))==0,"Published full contents match stage");
    Run($"UPDATE {Target} SET NAMOUNT_BENE=333 WHERE NPRODUCT=2 AND NMODULEC=15");
    Check(Count(Difference(Selected,stageSelect))>0,"External edits detected before restoration");
    Run($"UPDATE {Target} SET NAMOUNT_BENE=CASE NCOVER WHEN 1 THEN 100 ELSE 200 END WHERE NPRODUCT=2 AND NMODULEC=15");
    Run("BEGIN");Run(Delete);Run(Insert(Snapshot,"AND TIPO='ANTES'"));Run("ROLLBACK");
    Check(Count($"SELECT COUNT(*) FROM ({Selected})")==4,"Failed restoration rolls back all modules");
    Run("BEGIN");Run(Delete);Run(Insert(Snapshot,"AND TIPO='ANTES'"));Run("COMMIT");
    Check(Run($"SELECT NAMOUNT_BENE FROM {Target} WHERE NPRODUCT=2 AND NMODULEC=10")=="999","Restores previous benefits");
    Check(Count($"SELECT COUNT(*) FROM {Target} WHERE NPRODUCT=2 AND NMODULEC=15")==0,"Restores previously empty module");
    Console.WriteLine($"BeneficioReplica: {checks} comprobaciones correctas (SQL aislado, sin Oracle).");
}
finally{Native.Close(db);}

static class Native
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]public delegate int Callback(IntPtr state,int count,IntPtr values,IntPtr names);
    [DllImport("sqlite3",EntryPoint="sqlite3_open",CallingConvention=CallingConvention.Cdecl)]public static extern int Open([MarshalAs(UnmanagedType.LPUTF8Str)]string name,out IntPtr db);
    [DllImport("sqlite3",EntryPoint="sqlite3_exec",CallingConvention=CallingConvention.Cdecl)]public static extern int Exec(IntPtr db,[MarshalAs(UnmanagedType.LPUTF8Str)]string sql,Callback callback,IntPtr state,out IntPtr error);
    [DllImport("sqlite3",EntryPoint="sqlite3_free",CallingConvention=CallingConvention.Cdecl)]public static extern void Free(IntPtr memory);
    [DllImport("sqlite3",EntryPoint="sqlite3_close",CallingConvention=CallingConvention.Cdecl)]public static extern int Close(IntPtr db);
}
