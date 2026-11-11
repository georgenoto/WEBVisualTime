using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using WEBVisualTime.Datos.ImportacionPrimas;

// Execute the production DML against an isolated relational fixture. Only Oracle's
// UPDATE alias syntax and SYSDATE spelling are adapted. No Oracle connection/writes.
NativeLibrary.SetDllImportResolver(typeof(Native).Assembly,(name,assembly,path)=>name=="sqlite3"
    ?NativeLibrary.Load(OperatingSystem.IsWindows()?"winsqlite3.dll":OperatingSystem.IsMacOS()?"libsqlite3.dylib":"libsqlite3.so.0"):IntPtr.Zero);
if(Native.Open(":memory:",out var db)!=0)throw new Exception("Cannot open isolated SQL fixture");
int checks=0;
void Check(bool yes,string message){if(!yes)throw new Exception(message);checks++;}
string Sql(string sql)=>Regex.Replace(sql,"UPDATE (INSUDB\\.\\w+) ([st]) SET","UPDATE $1 AS $2 SET")
    .Replace("SYSDATE","CURRENT_TIMESTAMP").Replace(":id","'job'").Replace(":fecha","'2026-01-02'");
string Run(string sql)
{
    string result="";
    Native.Callback cb=(_,count,values,names)=>{if(count>0)result=Marshal.PtrToStringUTF8(Marshal.ReadIntPtr(values))??"";return 0;};
    var code=Native.Exec(db,Sql(sql),cb,IntPtr.Zero,out var error);
    if(code!=0){var text=Marshal.PtrToStringUTF8(error);Native.Free(error);throw new Exception($"SQL fixture: {text}");}
    GC.KeepAlive(cb);return result;
}
long Count(string sql)=>long.Parse(Run(sql),CultureInfo.InvariantCulture);
const string Target="INSUDB.TAR_HEALT_PREM",Stage="INSUDB.TEMP_VT_PRIMA_STAGE";
var columns=PrimaPublicacionSql.Columns.Split(',');
string Define(string col)=>col+(col.StartsWith('D')?" TEXT":" NUMERIC");
void Add(string table,params (string Key,string Value)[] overrides)
{
    var v=columns.ToDictionary(c=>c,_=>"1");
    foreach(var key in new[]{"NCAPITAL_INIT","NAGE_INIT"})v[key]="0";
    v["NCAPITAL_END"]="9999999";v["NAGE_END"]="0";v["DEFFECDATE"]="'2026-01-02'";v["DNULLDATE"]="NULL";v["DCOMPDATE"]="'2026-01-02'";
    v["NAMOUNTF"]="100";v["NAMOUNTM"]="200";
    foreach(var (key,value) in overrides)v[key]=value;
    Run($"INSERT INTO {table}({(table==Stage?"IMPORT_ID,":"")}{PrimaPublicacionSql.Columns}) VALUES({(table==Stage?"'job',":"")}{string.Join(',',columns.Select(c=>v[c]))})");
}
void Reset(){Run($"DELETE FROM {Stage};DELETE FROM {Target}");}
try
{
    Run("ATTACH DATABASE ':memory:' AS INSUDB");
    Run($"CREATE TABLE {Target}({string.Join(',',columns.Select(Define))},PRIMARY KEY({string.Join(',',PrimaPublicacionSql.Keys)}))");
    Run($"CREATE TABLE {Stage}(IMPORT_ID TEXT,RESULTADO TEXT DEFAULT 'PREPARADO',{string.Join(',',columns.Select(Define))})");
    Add(Target,("DEFFECDATE","'2024-01-01'"));Add(Stage,("NAGE_END","99"));
    Run(PrimaPublicacionSql.Close(Stage));
    Check(Run($"SELECT DNULLDATE FROM {Target}")=="2026-01-02","Reported case: old 0-0 closes for new 0-99");
    Check(Count(PrimaPublicacionSql.Existing(Stage))==0,"Different effect date/ranges are different primary keys");
    Run(PrimaPublicacionSql.Insert(Stage));Check(Count($"SELECT COUNT(*) FROM {Target}")==2,"Different band inserts normally");
    Check(Count(PrimaPublicacionSql.Existing(Stage))==1,"Repetition detected by primary key");
    Run(PrimaPublicacionSql.Insert(Stage));Check(Count($"SELECT COUNT(*) FROM {Target}")==2,"Repetition does not duplicate");
    Reset();Add(Target,("NAMOUNTM","999"),("DNULLDATE","'2027-01-01'"));Add(Stage);
    Check(Count(PrimaPublicacionSql.Existing(Stage))==1,"Different premium/expiry still count as the same primary key");
    Run(PrimaPublicacionSql.MarkExisting(Stage));Run(PrimaPublicacionSql.Insert(Stage));
    Check(Run($"SELECT RESULTADO FROM {Stage}")=="EXISTENTE"&&Count($"SELECT COUNT(*) FROM {Target}")==1,"Existing key is skipped and classified without blocking");
    Check(Run($"SELECT NAMOUNTM FROM {Target}")=="999"&&Run($"SELECT DNULLDATE FROM {Target}")=="2027-01-01","Skipped existing record is not overwritten");
    Reset();Add(Target,("DEFFECDATE","'2024-01-01'"),("NAGE_INIT","120"),("NAGE_END","130"),("NCAPITAL_INIT","500"),("NPOLICY_YEAR_END","10"));Add(Stage);
    Run(PrimaPublicacionSql.Close(Stage));Check(Run($"SELECT DNULLDATE FROM {Target}")=="2026-01-02","Renewal scope is independent of all age/capital/year ranges");
    foreach(var field in new[]{"NBRANCH","NPRODUCT","NROLE","NMODULEC","NCOVER","NGEOGRAPHAREA","NATTENSYSTEM","NOFFICE","NCURRENCY"})
    {
        Reset();Add(Target,("DEFFECDATE","'2024-01-01'"),(field,"2"));Add(Stage);Run(PrimaPublicacionSql.Close(Stage));
        Check(Count($"SELECT COUNT(*) FROM {Target} WHERE DNULLDATE IS NULL")==1,"Unselected dimension remains unchanged: "+field);
    }
    Reset();Add(Target,("DEFFECDATE","'2024-01-01'"),("DNULLDATE","'2025-01-01'"));Add(Stage);Run(PrimaPublicacionSql.Close(Stage));
    Check(Run($"SELECT DNULLDATE FROM {Target}")=="2025-01-01","Previously closed history remains unchanged");
    Reset();Add(Target,("DEFFECDATE","'2027-01-01'"));Add(Stage);Run(PrimaPublicacionSql.Close(Stage));Run(PrimaPublicacionSql.Insert(Stage));
    Check(Count($"SELECT COUNT(*) FROM {Target} WHERE DNULLDATE IS NULL")==2,"Future version is unchanged and distinct-key insertion is permitted");
    Reset();Add(Target,("DEFFECDATE","'2024-01-01'"));Add(Stage,("NAGE_END","99"));Run("BEGIN");Run(PrimaPublicacionSql.Close(Stage));Run(PrimaPublicacionSql.Insert(Stage));Run("ROLLBACK");
    Check(Count($"SELECT COUNT(*) FROM {Target}")==1&&Count($"SELECT COUNT(*) FROM {Target} WHERE DNULLDATE IS NULL")==1,"Rollback restores old validity and removes new insertion together");
    Console.WriteLine($"PrimaPublicacion: {checks} comprobaciones SQL correctas (base aislada, sin Oracle).");
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
