using System.Globalization;
using System.IO.Compression;
using System.Xml.Linq;
using WEBVisualTime.Servicios.ImportacionPrimas;
using WEBVisualTime.Entidades.ImportacionPrimas;

var checks=0;
void Check(bool condition,string message){if(!condition)throw new Exception(message);checks++;}
void Reject(Action action,string message){try{action();}catch(ArgumentException){checks++;return;}throw new Exception("Expected rejection: "+message);}
var reader=new PrimaExcelReader();
byte[] Book(string? max=null,string male="2661.7979",string ramo="5 Salud",bool formula=false,bool date1904=false,string? date=null)
{
 XNamespace x="http://schemas.openxmlformats.org/spreadsheetml/2006/main";
 var headers=new[]{"Ramo","Descripción","Producto","Fecha de efecto","Módulo","Cobertura ","Tipo Asegurado","Regional","Ámbito geográfico","Sistema de atención","Capital","Moneda ","mínima","Máxima"," Masculino","Femenino","Año de póliza inicial","Año de póliza final"};
 var values=new[]{ramo,"Salud <script>","1",date??(date1904?"44196":"45658"),"10","5 Atención","2 Asegurado","2 La Paz","1 Nacional","2 -abierto cerrado","","1 Bolivianos","0",max??"",male,"2500.1234","1","1"};
 XElement Cell(int col,int row,string value,bool text)=>new(x+"c",new XAttribute("r",$"{(char)('A'+col)}{row}"),text?new XAttribute("t","inlineStr"):null,text?new XElement(x+"is",new XElement(x+"t",value)):new XElement(x+"v",value),formula&&col==14&&row==3?new XElement(x+"f","1+1"):null);
 var data=new XDocument(new XElement(x+"worksheet",new XElement(x+"sheetData",new XElement(x+"row",new XAttribute("r",2),headers.Select((v,i)=>Cell(i,2,v,true))),new XElement(x+"row",new XAttribute("r",3),values.Select((v,i)=>Cell(i,3,v,new[]{0,1,5,6,7,8,9,11}.Contains(i)))))));
 using var ms=new MemoryStream();
 using(var zip=new ZipArchive(ms,ZipArchiveMode.Create,true))
 {
  void Write(string name,string text){using var w=new StreamWriter(zip.CreateEntry(name).Open());w.Write(text);}
  Write("xl/workbook.xml",$"<workbook xmlns='{x}' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships'><workbookPr date1904='{(date1904?1:0)}'/><sheets><sheet name='DATOS IMPORTADOS' sheetId='1' r:id='rId1'/></sheets></workbook>");
  Write("xl/_rels/workbook.xml.rels","<Relationships xmlns='http://schemas.openxmlformats.org/package/2006/relationships'><Relationship Id='rId1' Target='worksheets/sheet1.xml'/></Relationships>");
  Write("xl/worksheets/sheet1.xml",data.ToString());
 }
 return ms.ToArray();
}
var doc=reader.Leer(Book(),"test.xlsx");var f=doc.Filas.Single();
Check(f.Efecto==new DateTime(2025,1,1),"Excel date");
Check(f.EdadDesde==0&&f.EdadHasta==0,"Maximum defaults to minimum including zero");
Check(f.Masculino==2661.7979m&&f.Femenino==2500.1234m,"Sex-specific decimals preserved");
Check(f.Ramo==5&&f.Cobertura==5&&f.RegionalOriginal==2&&f.Atencion==2,"Code cleaning");
Check(reader.Leer(Book(date1904:true),"test.xlsm").Filas[0].Efecto==f.Efecto,"1904 date system");
foreach(var culture in new[]{"es-BO","es-ES","en-US"}){CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo(culture);Check(reader.Leer(Book(),"test.xlsx").Filas[0].Masculino==f.Masculino,"Locale independent decimals");}
Reject(()=>reader.Leer(Book(ramo:"Salud 5"),"test.xlsx"),"Bad code");
Reject(()=>reader.Leer(Book(male:"2.661,79"),"test.xlsx"),"Ambiguous separators");
Reject(()=>reader.Leer(Book(male:"-1"),"test.xlsx"),"Negative premium");
Reject(()=>reader.Leer(Book(formula:true),"test.xlsx"),"Formula");
Reject(()=>reader.Leer(Book(),"test.xls"),"Legacy file");
Reject(()=>reader.Leer(Book(date:"0"),"test.xlsx"),"Invalid date range");
var plan=new PrimaPlan(doc,[2,21],[1,3],7);PrimaExcelReader.ValidarPlan(plan);
Check(plan.Total==4,"Cartesian volume");
Check(plan.Item(0).Rol==2&&plan.Item(1).Rol==21&&plan.Item(2).Regional==3,"Stable ordering and role replacement");
var renewal=plan with{FechaEfecto=new DateTime(2026,1,2)};PrimaExcelReader.ValidarPlan(renewal);
Check(renewal.Item(0).Fila.Efecto==new DateTime(2026,1,2)&&renewal.Item(3).Fila.Efecto==new DateTime(2026,1,2),"Uniform effective date across all selected combinations");
Check(renewal.Documento.Filas[0].Efecto==new DateTime(2025,1,1),"Original Excel date preserved");
Reject(()=>PrimaExcelReader.ValidarPlan(renewal with{FechaEfecto=new DateTime(2026,1,2,12,0,0)}),"Effective date cannot include time");
Reject(()=>PrimaExcelReader.ValidarPlan(renewal with{FechaEfecto=new DateTime(1800,1,1)}),"Effective date bounded");
Reject(()=>PrimaExcelReader.ValidarPlan(renewal with{Documento=doc with{Filas=[f,f with{Fila=4,Efecto=new DateTime(2024,1,1)}]}}),"Date override must detect formerly different source keys");
var roundtrip=System.Text.Json.JsonSerializer.Deserialize<PrimaPlan>(System.Text.Json.JsonSerializer.Serialize(renewal));
Check(roundtrip?.FechaEfecto==renewal.FechaEfecto&&roundtrip.Item(0).Fila.Efecto==renewal.FechaEfecto,"Effective date survives durable JSON plan serialization");
var legacy=System.Text.Json.JsonSerializer.Deserialize<PrimaPlan>("{\"Documento\":"+System.Text.Json.JsonSerializer.Serialize(doc)+",\"Roles\":[2],\"Regionales\":[1],\"Usuario\":7}");
Check(legacy is not null&&legacy.FechaEfecto==null&&legacy.Item(0).Fila.Efecto==f.Efecto,"Previously frozen plans do not silently enable renewal");
Reject(()=>PrimaExcelReader.ValidarPlan(plan with{Roles=[]}),"Empty roles");
Reject(()=>PrimaExcelReader.ValidarPlan(plan with{Regionales=[]}),"Empty offices");
Reject(()=>PrimaExcelReader.ValidarPlan(plan with{Roles=[2,2]}),"Duplicate catalog codes");
Reject(()=>PrimaExcelReader.ValidarPlan(plan with{Documento=doc with{Filas=[f,f with{Fila=4,RolOriginal=21,RegionalOriginal=1}]}}),"Duplicate after role/office replacement");
Reject(()=>PrimaExcelReader.ValidarPlan(plan with{Documento=doc with{Filas=[f,f with{Fila=4,EdadHasta=5}]}}),"Overlapping ranges");
var large=doc with{Filas=Enumerable.Range(0,50_001).Select(i=>f with{Fila=i+3,EdadDesde=i,EdadHasta=i}).ToList()};
var largePlan=new PrimaPlan(large,[2,21],[1],7);PrimaExcelReader.ValidarPlan(largePlan);
Check(largePlan.Total==100_002&&largePlan.Item(100_001).Fila.Fila==50_003,"More than 50,000 final records");
Reject(()=>PrimaExcelReader.ValidarPlan(largePlan with{Roles=Enumerable.Range(1,101).ToArray()}),"Expansion bound");
if(args.Length>0)
{
 var actual=reader.Leer(File.ReadAllBytes(args[0]),Path.GetFileName(args[0]));var actualPlan=new PrimaPlan(actual,[2,21],[1],1);PrimaExcelReader.ValidarPlan(actualPlan);
 Check(actual.Filas.Count==9&&actualPlan.Total==18,"Original template counts");
 Check(actual.Filas[6].Masculino==1718.6403m&&actual.Filas[6].Femenino==1834.5591m,"Original template sex-specific premiums");
 Check(actualPlan.Item(1).Regional==1&&actualPlan.Item(1).Rol==21,"Original template expansion");
}
Console.WriteLine($"PrimaImportacion: {checks} comprobaciones correctas.");
