using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using WEBVisualTime.Entidades.ImportacionPrimas;
using WEBVisualTime.Servicios.ImportacionPrimas;
using WEBVisualTime.Web.Controllers;

var builder=WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://127.0.0.1:0");builder.Logging.ClearProviders();
builder.Configuration["CargaPrimas:Habilitado"]="true";
var store=new FakeStore();builder.Services.AddSingleton<IPrimaImportacionStore>(store);builder.Services.AddSingleton<PrimaExcelReader>();
builder.Services.AddControllersWithViews().AddApplicationPart(typeof(CargarPrimasController).Assembly).ConfigureApplicationPartManager(m=>m.FeatureProviders.Add(new OnlyPrimas()));
await using var app=builder.Build();app.UseRouting();app.MapControllerRoute("default","{controller=CargarPrimas}/{action=Index}/{id?}");await app.StartAsync();
var address=app.Services.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>()!.Addresses.Single();
using var http=new HttpClient(new HttpClientHandler{CookieContainer=new CookieContainer(),AllowAutoRedirect=true}){BaseAddress=new Uri(address)};
int checks=0;
void Check(bool yes,string message){if(!yes)throw new Exception(message);checks++;}
async Task<string> Get(string url){var r=await http.GetAsync(url);Check(r.StatusCode==HttpStatusCode.OK,$"GET {url}: {r.StatusCode}");return await r.Content.ReadAsStringAsync();}
string Token(string html)=>WebUtility.HtmlDecode(Regex.Match(html,"name=\"__RequestVerificationToken\"[^>]*value=\"([^\"]+)\"").Groups[1].Value);
async Task<string> Post(string action,string token,params(string Name,string Value)[] values)
{
 var data=values.Select(v=>new KeyValuePair<string,string>(v.Name,v.Value)).Append(new("__RequestVerificationToken",token));
 var r=await http.PostAsync("/CargarPrimas/"+action,new FormUrlEncodedContent(data));Check(r.StatusCode==HttpStatusCode.OK,$"POST {action}: {r.StatusCode}");return await r.Content.ReadAsStringAsync();
}
var html=await Get("/CargarPrimas");Check(html.Contains("Cargar Primas Por Producto")&&html.Contains("/CargarPrimas"),"Menu and module");
Check(!string.IsNullOrEmpty(Token(html)),"Antiforgery generated");
var denied=await http.PostAsync("/CargarPrimas/Ejecutar",new FormUrlEncodedContent(new Dictionary<string,string>{{"id",FakeStore.Id}}));Check(denied.StatusCode==HttpStatusCode.BadRequest,"Mutation without antiforgery denied");
html=await Get("/CargarPrimas/Seleccionar/"+FakeStore.Id);Check(html.Contains("Seleccionar roles")&&html.Contains("Seleccionar regionales")&&html.Contains("NUSERCODE"),"Selection steps");
html=await Post("Preparar",Token(html),("id",FakeStore.Id),("roles","2"),("roles","21"),("regionales","1"),("usuario","7"),("fechaEfecto","2026-01-02"));
Check(store.Plan?.Total==120,"Frozen expansion volume");
Check(store.Plan?.FechaEfecto==new DateTime(2026,1,2)&&html.Contains("02/01/2026")&&html.Contains("DNULLDATE"),"Effective date and renewal scope are explicit in review");
Check(html.Contains("clave primaria completa de 16 campos")&&html.Contains("aunque cambien los rangos")&&!html.Contains("mismos rangos"),"Review explains primary-key deduplication and closure across different bands");
Check(store.Plan!.Item(0).Fila.Efecto==new DateTime(2026,1,2)&&store.Doc.Filas[0].Efecto==new DateTime(2025,1,1),"New effective date overrides Excel without changing original");
Check(html.Contains("120 tarifas")&&html.Contains("Cambiar selección"),"Review and edit link");
Check(!html.Contains("<script>source</script>")&&html.Contains("&lt;script&gt;source&lt;/script&gt;"),"Spreadsheet descriptions HTML encoded");
Check(html.Contains("Página 1 de 3"),"Review paginated");
html=await Get("/CargarPrimas/Revisar/"+FakeStore.Id+"?pagina=999");Check(html.Contains("Página 3 de 3"),"Pagination bounded");
var revision=WebUtility.HtmlDecode(Regex.Match(html,"name=\"revision\" value=\"([^\"]+)\"").Groups[1].Value);
Check(revision.Length==64,"Review digest");
html=await Post("Ejecutar",Token(html),("id",FakeStore.Id),("revision",revision),("confirmar","true"));
Check(store.State=="EN_COLA"&&html.Contains("Carga y conciliación"),"Confirm queues import");
html=await Post("Pausar",Token(html),("id",FakeStore.Id));Check(store.State=="PAUSADO"&&html.Contains("Reanudar carga"),"Pause");
html=await Post("CambiarConfiguracion",Token(html),("id",FakeStore.Id));Check(store.State=="BORRADOR"&&html.Contains("2026-01-02"),"Paused import can revise date retaining selection");
html=await Post("Preparar",Token(html),("id",FakeStore.Id),("roles","2"),("roles","21"),("regionales","1"),("usuario","7"),("fechaEfecto",""));Check(store.State=="BORRADOR","Missing effective date cannot produce a reviewed plan");
html=await Post("Preparar",Token(html),("id",FakeStore.Id),("roles","2"),("roles","21"),("regionales","1"),("usuario","7"),("fechaEfecto","2026-01-02"));
store.State="PAUSADO";
html=await Post("Reanudar",Token(html),("id",FakeStore.Id));Check(store.State=="EN_COLA","Resume");
var response=await http.GetAsync("/CargarPrimas/Estado/"+FakeStore.Id);Check(response.StatusCode==HttpStatusCode.OK&&(await response.Content.ReadAsStringAsync()).Contains("EN_COLA"),"Polling JSON");
response=await http.GetAsync("/CargarPrimas/DescargarInforme/"+FakeStore.Id);Check(response.Content.Headers.ContentType?.MediaType=="application/json"&&response.Content.Headers.ContentDisposition?.FileName?.Contains("primas-")==true,"Download report");
store.Plan=store.Plan! with{TarifasAnterioresCerradas=60};store.State="COMPLETADO";
html=await Get("/CargarPrimas/Progreso/"+FakeStore.Id);Check(html.Contains("Tarifas anteriores cerradas")&&html.Contains("02/01/2026"),"Completion displays closed versions and effective date");
response=await http.GetAsync("/CargarPrimas/DescargarInforme/"+FakeStore.Id);var report=await response.Content.ReadAsStringAsync();Check(report.Contains("TarifasAnterioresCerradas")&&report.Contains("2026-01-02"),"Audit report includes renewal result");
builder.Configuration["CargaPrimas:Habilitado"]="false";
html=await Get("/CargarPrimas");Check(html.Contains("pendiente de habilitación")&&!html.Contains("enctype=\"multipart/form-data\""),"Disabled module does not permit upload");
Console.WriteLine($"PrimaFlow: {checks} comprobaciones HTTP correctas.");await app.StopAsync();

public sealed class OnlyPrimas:IApplicationFeatureProvider<ControllerFeature>
{
 public void PopulateFeature(IEnumerable<ApplicationPart> parts,ControllerFeature feature)
 {foreach(var c in feature.Controllers.Where(t=>t.AsType()!=typeof(CargarPrimasController)).ToArray())feature.Controllers.Remove(c);}
}
public sealed class FakeStore:IPrimaImportacionStore
{
 public const string Id="11111111111111111111111111111111";
 public string State="BORRADOR";public PrimaPlan? Plan;
 public PrimaDocumento Doc=new("test.xlsx",new string('A',64),Enumerable.Range(0,60).Select(i=>new PrimaFila(i+3,"<script>source</script>",5,1,new(2025,1,1),10,5,2,2,1,2,0,1,i,i,100.1234m,200.4321m,1,1)).ToList());
 public Task<string> CrearAsync(PrimaDocumento d,byte[] b,CancellationToken ct)=>Task.FromResult(Id);
 public Task<PrimaDocumento> DocumentoAsync(string id,CancellationToken ct)=>Task.FromResult(Doc);
 public Task<PrimaPlan?> PlanAsync(string id,CancellationToken ct)=>Task.FromResult(Plan);
 public Task<PrimaEstado> EstadoAsync(string id,CancellationToken ct)=>Task.FromResult(new PrimaEstado(Id,Doc.Archivo,State,Plan?.Total??0,0,0,0,null,DateTime.Today));
 public async Task<List<PrimaEstado>> RecientesAsync(CancellationToken ct)=>[await EstadoAsync(Id,ct)];
 public Task<PrimaCatalogos> CatalogosAsync(CancellationToken ct)=>Task.FromResult(new PrimaCatalogos([new(2,"Titular"),new(21,"Padres")],[new(1,"Santa Cruz")]));
 public Task ConfigurarAsync(string id,PrimaPlan plan,CancellationToken ct){Plan=plan;State="REVISADO";return Task.CompletedTask;}
 public Task EncolarAsync(string id,string revision,CancellationToken ct){State="EN_COLA";return Task.CompletedTask;}
 public Task ReanudarAsync(string id,CancellationToken ct){State="EN_COLA";return Task.CompletedTask;}
 public Task PausarAsync(string id,CancellationToken ct){State="PAUSADO";return Task.CompletedTask;}
 public Task EditarAsync(string id,CancellationToken ct){State="BORRADOR";return Task.CompletedTask;}
 public Task<bool> ProcesarSiguienteAsync(CancellationToken ct)=>Task.FromResult(false);
}
