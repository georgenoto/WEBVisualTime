using System.Data.Common;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Services.Common;
using ClientController = WEBVisualTime.Web.Insudb.Controllers.CLIENTController;

var builder=WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://127.0.0.1:0");
var logs=new RecordedLogs();
builder.Logging.ClearProviders();builder.Logging.AddProvider(logs);
var service=new FakeClients();
builder.Services.AddSingleton<ICLIENTService>(service);
foreach(var parameter in typeof(ClientController).GetConstructors().Single().GetParameters())
{
    if(parameter.ParameterType == typeof(ICLIENTService) || parameter.ParameterType.IsGenericType)continue;
    builder.Services.AddSingleton(parameter.ParameterType, _=>DispatchProxy.Create(parameter.ParameterType,typeof(UnusedLookup)));
}
builder.Services.AddControllersWithViews().AddApplicationPart(typeof(ClientController).Assembly)
    .ConfigureApplicationPartManager(m=>m.FeatureProviders.Add(new TestControllers()));
await using var app=builder.Build();
app.UseExceptionHandler("/Home/Error");
app.UseRouting();
app.MapGet("/test-unhandled",()=> { throw new InvalidOperationException("PRIVATE-DATABASE-DETAIL"); return ""; });
app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
await app.StartAsync();
var address=app.Services.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>()!.Addresses.Single();
using var http=new HttpClient {BaseAddress=new Uri(address)};
var checks=0;
void Check(bool value,string message) {if(!value)throw new Exception(message);checks++;}
async Task<string> Get(string url,HttpStatusCode expected)
{
    var response=await http.GetAsync(url);var text=await response.Content.ReadAsStringAsync();
    Check(response.StatusCode==expected,$"{url}: expected {expected}, got {response.StatusCode}");
    return text;
}
var html=await Get("/CLIENT",HttpStatusCode.OK);
Check(html.Contains("TEST-CLIENT") && html.Contains("4186 clientes"),"CLIENT must show records and the database total");
Check(html.Contains("Siguiente") && !html.Contains("data-table-search"),"CLIENT must use database paging and filtering");
Check(service.LastSize==20 && !service.GetAllCalled,"CLIENT menu must not load every record");
await Get("/CLIENT?page=2&pageSize=50&q=Ana",HttpStatusCode.OK);
Check(service.LastPage==2 && service.LastSize==50 && service.LastSearch=="Ana","Paging and search parameters must reach the service");
await Get("/CLIENT?page=-7&pageSize=999",HttpStatusCode.OK);
Check(service.LastPage==1 && service.LastSize==20,"Invalid paging must be bounded");
service.Mode="empty";
html=await Get("/CLIENT?q=missing",HttpStatusCode.OK);
Check(html.Contains("alert-info") && html.Contains("no se encontraron clientes") && !html.Contains("alert-danger"),"Empty results must be distinguished from errors");
foreach(var mode in new[]{"database","mapping","timeout"})
{
    service.Mode=mode;
    html=await Get("/CLIENT",mode=="mapping"?HttpStatusCode.InternalServerError:HttpStatusCode.ServiceUnavailable);
    Check(html.Contains("alert-danger") && html.Contains("Referencia:") && html.Contains("Reintentar"),"Failures must have an actionable message and reference");
    Check(!html.Contains("PRIVATE-DATABASE-DETAIL") && !html.Contains("no se encontraron clientes"),"Failures must not leak technical details or appear as empty results");
}
Check(logs.Exceptions.Count>=3,"Load failures must be logged with their exceptions");
html=await Get("/test-unhandled",HttpStatusCode.InternalServerError);
Check(html.Contains("Referencia:") && !html.Contains("PRIVATE-DATABASE-DETAIL"),"Global error endpoint must exist and hide technical details");
Console.WriteLine($"PASS: {checks} assertions: CLIENT records, NULL DTO fields, paging, search, empty results, database/mapping/timeout errors, logging and global error page. No Oracle connection.");
await app.StopAsync();

public class UnusedLookup:DispatchProxy
{
    protected override object? Invoke(MethodInfo? target,object?[]? arguments)=>throw new InvalidOperationException("Index must not load dropdown catalogs.");
}
sealed class TestControllers:IApplicationFeatureProvider<ControllerFeature>
{
    public void PopulateFeature(IEnumerable<ApplicationPart> parts,ControllerFeature feature)
    {
        foreach(var c in feature.Controllers.Where(c=>c.Name is not ("CLIENTController" or "HomeController")).ToList())feature.Controllers.Remove(c);
    }
}
sealed class RecordedLogs:ILoggerProvider
{
    public List<Exception> Exceptions {get;}=new();
    public ILogger CreateLogger(string categoryName)=>new Logger(this);
    public void Dispose() { }
    sealed class Logger(RecordedLogs owner):ILogger
    {
        public IDisposable? BeginScope<TState>(TState state) where TState:notnull=>null;
        public bool IsEnabled(LogLevel level)=>true;
        public void Log<TState>(LogLevel level,EventId eventId,TState state,Exception? exception,Func<TState,Exception?,string> formatter)
        {if(exception is not null)owner.Exceptions.Add(exception);}
    }
}
sealed class FakeDatabaseException:DbException {public FakeDatabaseException():base("PRIVATE-DATABASE-DETAIL") { }}
sealed class FakeClients:ICLIENTService
{
    public string Mode="records";
    public int LastPage,LastSize; public string? LastSearch; public bool GetAllCalled;
    public Task<PagedResult<CLIENTDto>> GetPageAsync(int page,int size,string? search=null,CancellationToken cancellationToken=default)
    {
        LastPage=page;LastSize=size;LastSearch=search;
        if(Mode=="database")throw new FakeDatabaseException();
        if(Mode=="mapping")throw new InvalidOperationException("PRIVATE-DATABASE-DETAIL");
        if(Mode=="timeout")throw new TimeoutException("PRIVATE-DATABASE-DETAIL");
        return Task.FromResult(Mode=="empty"?new PagedResult<CLIENTDto>(Array.Empty<CLIENTDto>(),0,1,size):
            new PagedResult<CLIENTDto>(new[]{new CLIENTDto {SCLIENT="TEST-CLIENT",SDIGIT="1",DCOMPDATE=DateTime.Today,NUSERCODE=1,NAFP=null,NCIVILSTA=null}},4186,page,size));
    }
    public Task<IEnumerable<CLIENTDto>> GetAllAsync() {GetAllCalled=true;throw new InvalidOperationException("Unbounded read");}
    public Task<CLIENTDto?> GetByIdAsync(string id)=>throw new NotSupportedException();
    public Task<CLIENTDto> CreateAsync(CreateCLIENTDto dto)=>throw new NotSupportedException();
    public Task<bool> UpdateAsync(string id,UpdateCLIENTDto dto)=>throw new NotSupportedException();
    public Task<bool> DeleteAsync(string id)=>throw new NotSupportedException();
    public Task<IEnumerable<CLIENTDto>> FindAsync(Expression<Func<CLIENT,bool>> predicate)=>throw new NotSupportedException();
}
