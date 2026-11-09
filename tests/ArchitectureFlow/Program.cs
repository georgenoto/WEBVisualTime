using System.Data.Common;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http.Json;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using WEBVisualTime.Entidades.Common;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS;
using WEBVisualTime.Servicios.Services.Common;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.WebHost.UseUrls("http://127.0.0.1:0");
var data = new AddressService();
builder.Services.AddSingleton<IADDRESSService>(data);
builder.Services.AddSingleton(DispatchProxy.Create<ICLIENTService, LookupProxy>());
builder.Services.AddSingleton(DispatchProxy.Create<ITABLE66Service, LookupProxy>());
builder.Services.AddSingleton(DispatchProxy.Create<IPROVINCEService, LookupProxy>());
builder.Services.AddSingleton(DispatchProxy.Create<ITAB_LOCATService, LookupProxy>());
builder.Services.AddSingleton(DispatchProxy.Create<IMUNICIPALITYService, LookupProxy>());
builder.Services.AddProblemDetails();
builder.Services.AddExceptionHandler<WEBVisualTime.WebApi.Infrastructure.ApiExceptionHandler>();
builder.Services.AddControllersWithViews(o => o.Filters.Add<WEBVisualTime.Web.Controllers.Common.OperationExceptionFilter>())
    .AddApplicationPart(typeof(WEBVisualTime.Web.Insudb.Controllers.ADDRESSController).Assembly)
    .AddApplicationPart(typeof(WEBVisualTime.WebApi.Insudb.Controllers.ADDRESSController).Assembly)
    .ConfigureApplicationPartManager(m => m.FeatureProviders.Add(new OnlyAddress()));
await using var app = builder.Build();
app.UseExceptionHandler();
app.MapControllerRoute("default", "{controller}/{action=Index}/{id?}");
await app.StartAsync();
var url = app.Services.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>()!.Addresses.Single();
using var client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false, CookieContainer = new() }) { BaseAddress = new Uri(url) };
var checks = 0;
void Check(bool value, string message) { if (!value) throw new Exception(message); checks++; }
var apiControllers = typeof(WEBVisualTime.WebApi.Insudb.Controllers.ADDRESSController).Assembly.GetTypes()
    .Where(t => !t.IsAbstract && typeof(ControllerBase).IsAssignableFrom(t)).ToArray();
Check(apiControllers.Length == 1017, "Every API module must be covered");
foreach (var controller in apiControllers)
{
    var listing = controller.GetMethod("GetAll")!;
    var response = listing.ReturnType.GetGenericArguments()[0].GetGenericArguments()[0];
    Check(response.IsGenericType && response.GetGenericTypeDefinition() == typeof(PagedResult<>), "Unpaged API module: " + controller.Name);
    Check(controller.GetMethod("Update")!.GetCustomAttribute<HttpPutAttribute>()!.Template == "{id}", "Invalid PUT route: " + controller.Name);
    Check(controller.GetMethod("Delete")!.GetCustomAttribute<HttpDeleteAttribute>()!.Template == "{id}", "Invalid DELETE route: " + controller.Name);
    var name = controller.Name[..^"Controller".Length];
    if (RecordKeys.IsComposite(name))
        Check(controller.GetMethod("GetById")!.GetParameters()[0].ParameterType == typeof(string), "Incomplete composite API contract: " + name);
}
async Task<string> Html(string path)
{
    var response = await client.GetAsync(path);
    var body = await response.Content.ReadAsStringAsync();
    Check(response.StatusCode == HttpStatusCode.OK, path + " failed: " + body[..Math.Min(body.Length, 300)]);
    return body;
}
foreach (var request in new[] { ("",20), ("?pageSize=1",1), ("?pageSize=25",25), ("?pageSize=999",20) })
{
    var page = await client.GetFromJsonAsync<PagedResult<ADDRESSDto>>("/api/ADDRESS" + request.Item1);
    Check(page!.PageSize == request.Item2 && page.TotalCount == 2, "API pagination metadata");
    Check(page.Items.Count == Math.Min(2, request.Item2), "API bounded items");
    Check(page.RecordKeys!.Count == page.Items.Count, "API provides full record identifiers");
}
var first = data.Rows[0]; var second = data.Rows[1];
var firstKey = RecordKeys.Encode("ADDRESS", first); var secondKey = RecordKeys.Encode("ADDRESS", second);
var index = await Html("/ADDRESS");
Check(index.Contains(firstKey) && index.Contains(secondKey), "MVC must link both complete keys");
foreach (var pair in new[] { (firstKey, "First"), (secondKey, "Second") })
{
    var result = await client.GetFromJsonAsync<ADDRESSDto>("/api/ADDRESS/" + pair.Item1);
    Check(result!.SSTREET == pair.Item2, "API must distinguish rows with identical first key columns");
    Check((await Html("/ADDRESS/Details/" + pair.Item1)).Contains(pair.Item2), "MVC details exact row");
}
var edit = await Html("/ADDRESS/Edit/" + secondKey);
var csrf = WebUtility.HtmlDecode(Regex.Match(edit,"name=\"__RequestVerificationToken\"[^>]*value=\"([^\"]+)\"").Groups[1].Value);
Check(csrf.Length > 0, "Edit must retain CSRF protection");
var edited = await client.PostAsync("/ADDRESS/Edit/"+secondKey, new FormUrlEncodedContent(new Dictionary<string,string>
{
    ["__RequestVerificationToken"] = csrf, ["NRECOWNER"] = second.NRECOWNER.ToString(),
    ["SKEYADDRESS"] = second.SKEYADDRESS, ["DEFFECDATE"] = first.DEFFECDATE.ToString("O"), ["SSTREET"] = "Edited second"
}));
Check(edited.StatusCode == HttpStatusCode.Redirect, "MVC edit complete key");
Check(first.SSTREET == "First" && second.SSTREET == "Edited second", "MVC edit must preserve the route key even if hidden fields change");
var updated = await client.PutAsJsonAsync("/api/ADDRESS/"+firstKey, new UpdateADDRESSDto
    { NRECOWNER=first.NRECOWNER, SKEYADDRESS=first.SKEYADDRESS, DEFFECDATE=first.DEFFECDATE, SSTREET="API first" });
Check(updated.StatusCode == HttpStatusCode.NoContent && first.SSTREET == "API first", "Specialized PUT route must bind full key");
foreach (var path in new[] { "/api/ADDRESS/7", "/api/ADDRESS/~invalid", "/ADDRESS/Details/7" })
    Check((await client.GetAsync(path)).StatusCode == HttpStatusCode.BadRequest, "Incomplete key must return 400: "+path);
foreach (var failure in new[] { ("db-error", HttpStatusCode.ServiceUnavailable), ("mapping-error", HttpStatusCode.InternalServerError) })
{
    var response = await client.GetAsync("/api/ADDRESS?q="+failure.Item1);
    var body = await response.Content.ReadAsStringAsync();
    Check(response.StatusCode == failure.Item2, "API error classification");
    Check(body.Contains("traceId") && !body.Contains("SECRET_SQL"), "API errors must include reference and hide internals");
}
var delete = await Html("/ADDRESS/Delete/"+secondKey);
Check(delete.Contains("value=\""+secondKey+"\""), "MVC confirmation must post complete key");
Check((await client.DeleteAsync("/api/ADDRESS/"+secondKey)).StatusCode == HttpStatusCode.NoContent, "Specialized DELETE route");
Check(data.Rows.Count == 1 && data.Rows[0] == first, "Delete must preserve row with same first key column");
Console.WriteLine($"PASS: {checks} architecture HTTP assertions: paged API, composite keys, MVC edit/delete forms, specialized routes and safe errors. No Oracle connection.");
await app.StopAsync();

sealed class OnlyAddress : IApplicationFeatureProvider<ControllerFeature>
{
    public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
    {
        foreach (var controller in feature.Controllers.Where(c => c.Name != "ADDRESSController").ToArray()) feature.Controllers.Remove(controller);
    }
}
public class LookupProxy : DispatchProxy
{
    protected override object? Invoke(MethodInfo? method, object?[]? args)
    {
        var type = method!.ReturnType.GetGenericArguments()[0];
        var empty = Activator.CreateInstance(typeof(List<>).MakeGenericType(type.GetGenericArguments()[0]));
        return typeof(Task).GetMethod(nameof(Task.FromResult))!.MakeGenericMethod(type).Invoke(null, new[] { empty });
    }
}
sealed class AddressService : IADDRESSService
{
    public List<ADDRESSDto> Rows { get; } = new()
    {
        new() { NRECOWNER=7, SKEYADDRESS="A/B +ñ", DEFFECDATE=new DateTime(2026,11,6), SSTREET="First" },
        new() { NRECOWNER=7, SKEYADDRESS="A/B +ñ", DEFFECDATE=new DateTime(2026,11,7), SSTREET="Second" }
    };
    public Task<IEnumerable<ADDRESSDto>> GetAllAsync() => throw new Exception("Unbounded listing must not be called");
    public Task<IEnumerable<ADDRESSDto>> FindAsync(Expression<Func<ADDRESS,bool>> predicate) => Task.FromResult<IEnumerable<ADDRESSDto>>(Rows);
    public Task<PagedResult<ADDRESSDto>> GetListPageAsync(int page=1,string? search=null,CancellationToken cancellationToken=default,int pageSize=20)
    {
        if (search == "db-error") throw new DatabaseFailure();
        if (search == "mapping-error") throw new InvalidOperationException("SECRET_SQL mapping");
        pageSize=ListingPolicy.NormalizePageSize(pageSize);
        var items=Rows.Take(pageSize).ToArray();
        return Task.FromResult(new PagedResult<ADDRESSDto>(items,Rows.Count,1,pageSize) { RecordKeys=items.Select(x=>RecordKeys.Encode("ADDRESS",x)).ToArray() });
    }
    public Task<ADDRESSDto?> GetByIdAsync(string id)
    {
        RecordKeys.Decode("ADDRESS",id);
        return Task.FromResult(Rows.SingleOrDefault(x => RecordKeys.Encode("ADDRESS",x)==id));
    }
    public async Task<bool> UpdateAsync(string id, UpdateADDRESSDto dto)
    {
        var row=await GetByIdAsync(id); if(row is null)return false; row.SSTREET=dto.SSTREET; return true;
    }
    public async Task<bool> DeleteAsync(string id) { var row=await GetByIdAsync(id); return row is not null && Rows.Remove(row); }
    public Task<ADDRESSDto> CreateAsync(CreateADDRESSDto dto) => throw new NotSupportedException();
}
sealed class DatabaseFailure : DbException { public DatabaseFailure() : base("SECRET_SQL database") { } }
