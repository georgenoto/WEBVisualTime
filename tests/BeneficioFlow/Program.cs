using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using WEBVisualTime.Entidades.ReplicaBeneficios;

using WEBVisualTime.Web.Controllers;

var builder=WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://127.0.0.1:0");builder.Logging.ClearProviders();
builder.Configuration["ReplicaBeneficios:Habilitado"]="true";
var store=new FakeStore();builder.Services.AddSingleton<IReplicaBeneficiosStore>(store);
builder.Services.AddControllersWithViews().AddApplicationPart(typeof(ReplicarBeneficiosController).Assembly).ConfigureApplicationPartManager(m=>m.FeatureProviders.Add(new OnlyBeneficios()));
await using var app=builder.Build();app.UseRouting();app.MapControllerRoute("default","{controller=ReplicarBeneficios}/{action=Index}/{id?}");await app.StartAsync();
var address=app.Services.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>()!.Addresses.Single();
using var http=new HttpClient(new HttpClientHandler{CookieContainer=new CookieContainer(),AllowAutoRedirect=true}){BaseAddress=new Uri(address)};
int checks=0;
void Check(bool yes,string message){if(!yes)throw new Exception(message);checks++;}
async Task<string> Get(string url){var r=await http.GetAsync(url);Check(r.StatusCode==HttpStatusCode.OK,$"GET {url}: {r.StatusCode}");return await r.Content.ReadAsStringAsync();}
string Token(string html)=>WebUtility.HtmlDecode(Regex.Match(html,"name=\"__RequestVerificationToken\"[^>]*value=\"([^\"]+)\"").Groups[1].Value);
async Task<string> Post(string action,string token,params(string Name,string Value)[] values)
{
 var data=values.Select(v=>new KeyValuePair<string,string>(v.Name,v.Value)).Append(new("__RequestVerificationToken",token));
 var r=await http.PostAsync("/ReplicarBeneficios/"+action,new FormUrlEncodedContent(data));Check(r.StatusCode==HttpStatusCode.OK,$"POST {action}: {r.StatusCode}");return await r.Content.ReadAsStringAsync();
}

var html=await Get("/ReplicarBeneficios?producto=2");
Check(Regex.IsMatch(html,"name=\"usuario\"[^>]*value=\"1\""),"Default user is 1");
Check(html.Contains("Salud &lt;especial&gt;")&&html.Contains("11/11/2026 09:20:00")&&html.Contains("11/11/2026 09:25:00"),"History displays encoded product and creation/execution dates");
Check(html.Contains("Ver detalle")&&html.Contains("Destinos")&&html.Contains("Estado"),"Descriptive history");
var denied=await http.PostAsync("/ReplicarBeneficios/Preparar",new FormUrlEncodedContent(new Dictionary<string,string>()));
Check(denied.StatusCode==HttpStatusCode.BadRequest,"CSRF blocks preparation without token");
html=await Get("/ReplicarBeneficios/Operacion/"+FakeStore.Id);
Check(html.Contains("Volver y modificar selección"),"Review has back link");
html=await Get("/ReplicarBeneficios?id="+FakeStore.Id);
Check(Regex.IsMatch(html,"value=\"10\"[^>]*checked"),"Selected destination preserved when returning");
Check(Regex.IsMatch(html,"value=\"5\"[^>]*selected"),"Base preserved when returning");
var stale=store.Revision;
html=await Post("Preparar",Token(html),("id",FakeStore.Id),("revision",stale),("producto","2"),("moduloBase","5"),("destinos","10"),("destinos","15"),("usuario","1"));
Check(store.Plan.Destinos.SequenceEqual(new[]{10,15})&&store.Revision!=stale,"Add destination and invalidate prior revision");
html=await Get("/ReplicarBeneficios?id="+FakeStore.Id);
html=await Post("Preparar",Token(html),("id",FakeStore.Id),("revision",store.Revision),("producto","2"),("moduloBase","5"),("destinos","15"),("usuario","1"));
Check(store.Plan.Destinos.SequenceEqual(new[]{15}),"Remove destination before execution");
var current=store.Revision; var validToken=Token(html);
html=await Post("Accion",Token(html),("id",FakeStore.Id),("accion","ejecutar"),("revision",stale),("confirmar","true"));
Check(store.State=="REVISADO","Stale review cannot execute");
html=await Post("Accion",Token(html),("id",FakeStore.Id),("accion","ejecutar"),("revision",current),("confirmar","true"));
Check(store.State=="EN_COLA","Current review queues operation");
Check(!html.Contains("Pausar entre segmentos")&&!html.Contains("Actualizar progreso")&&html.Contains("beneficios-progreso"),"Active operation has automatic progress without extra buttons");
html=await Get("/ReplicarBeneficios?id="+FakeStore.Id);
Check(!html.Contains("Guardar cambios y revisar"),"Running operation cannot return to edit");
html=await Post("Preparar",validToken,("id",FakeStore.Id),("revision",current),("producto","2"),("moduloBase","5"),("destinos","10"),("usuario","1"));
Check(store.Plan.Destinos.SequenceEqual(new[]{15})&&store.State=="EN_COLA","Direct edit after execution rejected");
store.State="ERROR";html=await Get("/ReplicarBeneficios/Operacion/"+FakeStore.Id);
Check(html.Contains("Reintentar desde el avance confirmado"),"Error recovery retained");
store.State="COMPLETADO";html=await Get("/ReplicarBeneficios/Operacion/"+FakeStore.Id);
Check(!html.Contains("Restaurar respaldo")&&!html.Contains("name=\"accion\" value=\"restaurar\"")&&html.Contains("Réplica confirmada"),"Completion has result without restoration form");
Console.WriteLine($"BeneficioFlow: {checks} comprobaciones HTTP correctas (sin Oracle).");await app.StopAsync();
public sealed class OnlyBeneficios:IApplicationFeatureProvider<ControllerFeature>
{
 public void PopulateFeature(IEnumerable<ApplicationPart> parts,ControllerFeature feature)
 {foreach(var c in feature.Controllers.Where(t=>t.AsType()!=typeof(ReplicarBeneficiosController)).ToArray())feature.Controllers.Remove(c);}
}
public sealed class FakeStore:IReplicaBeneficiosStore
{
 public const string Id="11111111111111111111111111111111";
 public string State="REVISADO",Revision="revision1"; public BeneficioPlan Plan=new(5,2,5,[10],1);
 public Task<List<BeneficioOpcion>> ProductosAsync(CancellationToken ct)=>Task.FromResult(new List<BeneficioOpcion>{new(2,"Salud <especial>")});
 public Task<List<BeneficioOpcion>> ModulosAsync(int p,CancellationToken ct)=>Task.FromResult(new List<BeneficioOpcion>{new(5,"Base"),new(10,"A"),new(15,"B")});
 public Task<List<BeneficioResumen>> RecientesAsync(CancellationToken ct)=>Task.FromResult(new List<BeneficioResumen>{new(Id,"COMPLETADO",Plan,new(2026,11,11,9,20,0),new(2026,11,11,9,25,0))});
 public Task<string> CrearAsync(BeneficioPlan p,CancellationToken ct){p.Validar();Plan=p;return Task.FromResult(Id);}
 public Task EditarAsync(string id,string rev,BeneficioPlan p,CancellationToken ct)
 {if(State!="REVISADO"||rev!=Revision)throw new ArgumentException("Revisión inválida");p.Validar();Plan=p;Revision=Guid.NewGuid().ToString();return Task.CompletedTask;}
 public Task<BeneficioEstado> EstadoAsync(string id,CancellationToken ct)=>Task.FromResult(new BeneficioEstado(Id,State,Plan,10,Plan.Destinos.Length*10,0,0,null,Revision,Plan.Destinos.Select(d=>new BeneficioDestino(d,2)).ToList()));
 public Task AccionAsync(string id,string accion,string? rev,CancellationToken ct)
 {if(accion=="ejecutar"&&State=="REVISADO"&&rev==Revision)State="EN_COLA";else throw new ArgumentException("Revisión inválida");return Task.CompletedTask;}
 public Task<bool> ProcesarAsync(CancellationToken ct)=>Task.FromResult(false);
}
