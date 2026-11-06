using System.Net;
using System.Net.Http.Json;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using WEBVisualTime.Servicios.Services.Common;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE999;
using WEBVisualTime.Servicios.Insudb.DTOs.APPUSER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8006;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8007;
using WEBVisualTime.Entidades.Common;

// Exercise the real controllers and compiled Razor views with in-memory services.
var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.WebHost.UseUrls("http://127.0.0.1:0");
builder.Services.AddSingleton<ITABLE2000Service, NumberCatalog>();
builder.Services.AddSingleton<ITABLE999Service, StringCatalog>();
builder.Services.AddSingleton<IAPPUSERService, WideUserCatalog>();
builder.Services.AddSingleton<ITABLE8006Service, DuplicateFactor>();
builder.Services.AddSingleton<ITABLE8007Service, DuplicateBase>();
var webAssembly = typeof(WEBVisualTime.Web.Insudb.Controllers.TABLE2000Controller).Assembly;
var apiAssembly = typeof(WEBVisualTime.WebApi.Insudb.Controllers.TABLE2000Controller).Assembly;
builder.Services.AddControllersWithViews().AddApplicationPart(webAssembly).AddApplicationPart(apiAssembly)
    .ConfigureApplicationPartManager(manager => manager.FeatureProviders.Add(new OnlyTestCatalogs()));
await using var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseRouting();
app.MapControllerRoute("default", "{controller}/{action=Index}/{id?}");
await app.StartAsync();
var address = app.Services.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>()!.Addresses.Single();
using var client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false, CookieContainer = new CookieContainer() }) { BaseAddress = new Uri(address) };
var checks = 0;
void Check(bool condition, string message) { if (!condition) throw new Exception(message); checks++; }
async Task<string> Page(string url)
{
    var response = await client.GetAsync(url);
    var html = await response.Content.ReadAsStringAsync();
    Check(response.StatusCode == HttpStatusCode.OK, url + ": " + response.StatusCode + " " + html[..Math.Min(html.Length, 1200)]);
    return html;
}
async Task<HttpResponseMessage> PostForm(string url, string html, Dictionary<string,string> fields)
{
    var token = Regex.Match(html, "name=\"__RequestVerificationToken\"[^>]*value=\"([^\"]+)\"");
    Check(token.Success, "CSRF token missing: " + url);
    fields["__RequestVerificationToken"] = WebUtility.HtmlDecode(token.Groups[1].Value);
    return await client.PostAsync(url, new FormUrlEncodedContent(fields));
}

foreach (var (name, key, id) in new[] { ("TABLE2000", "NAPLY", "7"), ("TABLE999", "SSTAT_ERROR", "A") })
{
    var html = await Page($"/{name}");
    Check(html.Contains($"<title>{name} - WEBVisualTime.Web</title>"), "Shared listings must retain the page title");
    Check(html.Contains("Original &lt;script&gt;"), "Index must HTML-encode values");
    Check(html.Contains($"/{name}/Edit/{id}"), "Existing action links must remain valid");
    var create = await Page($"/{name}/Create");
    Check(create.Contains("name=\"SDESCRIPT\""), "Shared form fields missing");
    var invalid = await PostForm($"/{name}/Create", create, new() { ["DCOMPDATE"] = "not-a-date" });
    var invalidHtml = await invalid.Content.ReadAsStringAsync();
    Check(invalid.StatusCode == HttpStatusCode.OK && invalidHtml.Contains("not-a-date") && invalidHtml.Contains("validation-summary-errors"), "Invalid values must be retained with validation errors");
    var valid = await PostForm($"/{name}/Create", create, new() { [key] = name == "TABLE2000" ? "42" : "NEW", ["SDESCRIPT"] = "Created", ["DCOMPDATE"] = "2026-11-06T10:25:30" });
    Check(valid.StatusCode == HttpStatusCode.Redirect, "Create must redirect");
    var edit = await Page($"/{name}/Edit/{id}");
    Check(edit.Contains("type=\"hidden\"") && edit.Contains($"name=\"{key}\""), "Edit must retain the original key");
    var missingToken = await client.PostAsync($"/{name}/Edit/{id}", new FormUrlEncodedContent(new Dictionary<string,string> { [key] = id }));
    Check(missingToken.StatusCode == HttpStatusCode.BadRequest, "CSRF must be enforced");
    var updated = await PostForm($"/{name}/Edit/{id}", edit, new() { [key] = id, ["SDESCRIPT"] = "Updated" });
    Check(updated.StatusCode == HttpStatusCode.Redirect, "Edit must redirect");
    Check((await Page($"/{name}/Details/{id}")).Contains("Updated"), "Edit must persist through the service");
    var delete = await Page($"/{name}/Delete/{id}");
    var deleted = await PostForm($"/{name}/Delete/{id}", delete, new() { ["id"] = id });
    Check(deleted.StatusCode == HttpStatusCode.Redirect, "Delete must redirect");
    Check((await client.GetAsync($"/{name}/Details/{id}")).StatusCode == HttpStatusCode.NotFound, "Deleted records must return 404");
}

var createdApi = await client.PostAsJsonAsync("/api/TABLE2000", new CreateTABLE2000Dto { NAPLY = 55, SDESCRIPT = "API created" });
Check(createdApi.StatusCode == HttpStatusCode.Created && createdApi.Headers.Location?.ToString().EndsWith("/api/TABLE2000/55") == true, "API POST and CreatedAtAction route");
Check((await client.GetAsync("/api/TABLE2000/55")).IsSuccessStatusCode, "API GET by numeric key");
Check((await client.PutAsJsonAsync("/api/TABLE2000/55", new UpdateTABLE2000Dto { NAPLY = 55, SDESCRIPT = "API updated" })).StatusCode == HttpStatusCode.NoContent, "API PUT route");
Check((await client.DeleteAsync("/api/TABLE2000/55")).StatusCode == HttpStatusCode.NoContent, "API DELETE route");
Check((await client.PutAsJsonAsync("/api/TABLE2000/987", new UpdateTABLE2000Dto { NAPLY = 987 })).StatusCode == HttpStatusCode.NotFound, "API missing key returns 404");
Check((await client.GetAsync("/api/TABLE2000/not-a-number")).StatusCode == HttpStatusCode.BadRequest, "Numeric keys must reject invalid input");
Check((await client.PutAsJsonAsync("/api/TABLE999/NEW", new UpdateTABLE999Dto { SSTAT_ERROR = "NEW", SDESCRIPT = "String API" })).StatusCode == HttpStatusCode.NoContent, "API PUT string key");
Check((await client.DeleteAsync("/api/TABLE999/NEW")).StatusCode == HttpStatusCode.NoContent, "API DELETE string key");
Check((await Page("/TABLE999")).Contains("no se encontraron registros"), "Empty catalog message");
Check((await Page("/APPUSER/Edit/3000000000")).Contains("3000000000"), "MVC keys above Int32 must not be truncated");
Check((await client.GetAsync("/api/APPUSER/3000000000")).IsSuccessStatusCode, "API must accept corrected Int64 keys");
Check((await client.PutAsJsonAsync("/api/APPUSER/3000000000", new UpdateAPPUSERDto { NIDUSER=3_000_000_000L, SUSERNAME="Wide key" })).StatusCode == HttpStatusCode.NoContent, "Corrected Int64 update contract");
foreach(var table in new[]{"TABLE8006","TABLE8007"})
{
    var readOnly=await Page("/"+table);
    Check(readOnly.Contains("First duplicate") && readOnly.Contains("Second duplicate"),"Duplicate rows must remain visible");
    Check(readOnly.Contains("códigos duplicados") || readOnly.Contains("c&#xF3;digos duplicados"),"Read-only catalogs must explain their restriction");
    Check(!readOnly.Contains("/"+table+"/Create") && !readOnly.Contains("/"+table+"/Edit/") && !readOnly.Contains("/"+table+"/Delete/"),"Unsafe actions must not be offered");
    Check((await client.GetAsync("/"+table+"/Edit/1")).StatusCode==HttpStatusCode.Conflict,"Direct edit URLs must be blocked");
    Check((await client.GetAsync("/api/"+table+"/1")).StatusCode==HttpStatusCode.Conflict,"API must reject ambiguous keys");
    Check((await client.DeleteAsync("/api/"+table+"/1")).StatusCode==HttpStatusCode.Conflict,"API deletion must be blocked");
}
Check((await client.PostAsJsonAsync("/api/TABLE8006",new CreateTABLE8006Dto {NTYPEAFEC=1,DCOMPDATE=DateTime.Today,NUSERCODE=1})).StatusCode==HttpStatusCode.Conflict,"API creation must be blocked");
Check((await client.PutAsJsonAsync("/api/TABLE8007/1",new UpdateTABLE8007Dto {NAFECBASADI=1,DCOMPDATE=DateTime.Today,NUSERCODE=1})).StatusCode==HttpStatusCode.Conflict,"API updates must be blocked");
var middlePage=await Page("/TABLE2000?page=2");
Check(Regex.Matches(middlePage,"<tr>").Count==21,"Lists must default to 20 records");
Check(middlePage.Contains("name=\"pageSize\""),"Every listing must expose a page-size selector");
var fifty=await Page("/TABLE2000?pageSize=50");
Check(Regex.Matches(fifty,"<tr>").Count==46 && fifty.Contains("data-page-size=\"50\""),"Selecting 50 must retrieve and render up to 50 records");
var custom=await Page("/TABLE2000?pageSize=25");
Check(Regex.Matches(custom,"<tr>").Count==26 && custom.Contains("value=\"25\""),"A valid custom page size must be retained");
Check((await Page("/TABLE2000?pageSize=999")).Contains("data-page-size=\"20\""),"Invalid page sizes must return to the default");
var lastPage=await Page("/TABLE2000?page=99999");
Check(lastPage.Contains("Página 3 de 3") && Regex.Matches(lastPage,"<tr>").Count==6,"Last page must clamp to five remaining records");
var searched=await Page("/TABLE2000?page=2&pageSize=10&q=Seed");
Check(searched.Contains("q=Seed") && searched.Contains("pageSize=10") && searched.Contains("Anterior") && searched.Contains("Siguiente"),"Page links must preserve filters and selected size");

// Exercise the real shared service and existing mappings with an isolated repository.
var repository = new NumberRepository();
var realService = new TABLE2000Service(repository);
await realService.CreateAsync(new CreateTABLE2000Dto { NAPLY = 91, SDESCRIPT = "Mapped" });
Check((await realService.GetByIdAsync(91))?.SDESCRIPT == "Mapped", "Real service create/get mapping");
await realService.UpdateAsync(91, new UpdateTABLE2000Dto { NAPLY = 91, SDESCRIPT = "Mapped update" });
Check((await realService.FindAsync(e => e.NAPLY == 91)).Single().SDESCRIPT == "Mapped update", "Real service update/find mapping");
var mappedPage=await realService.GetListPageAsync(1);
Check(mappedPage.PageSize==20 && mappedPage.TotalCount==1 && mappedPage.Items.Single().SDESCRIPT=="Mapped update","Shared service must delegate paged reads and retain its mapping");
Check(await realService.DeleteAsync(91) && !await realService.DeleteAsync(91) && repository.Saves == 3, "Real service deletion and save boundaries");
Console.WriteLine($"PASS: {checks} HTTP assertions: numeric/string keys, MVC CRUD, Razor, HTML encoding, invalid forms, CSRF and API routes. No Oracle connection.");
await app.StopAsync();

sealed class OnlyTestCatalogs : IApplicationFeatureProvider<ControllerFeature>
{
    public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
    {
        foreach (var controller in feature.Controllers.Where(c => c.Name is not ("TABLE2000Controller" or "TABLE999Controller" or "APPUSERController" or "TABLE8006Controller" or "TABLE8007Controller")).ToList())
            feature.Controllers.Remove(controller);
    }
}

abstract class MemoryCatalog<TDto,TCreate,TUpdate,TKey> : IService<TDto,TCreate,TUpdate,TKey>
    where TDto : class,new() where TCreate : class where TUpdate : class where TKey : notnull
{
    private readonly Dictionary<TKey,TDto> records = new();
    private readonly PropertyInfo key;
    private readonly TKey defaultKey;
    protected void Seed(TKey id,string description)
    {
        var dto=new TDto();key.SetValue(dto,id);
        typeof(TDto).GetProperty("SDESCRIPT")!.SetValue(dto,description);
        records[id]=dto;
    }
    protected MemoryCatalog(string keyName, TKey initialKey, TKey defaultKey, string descriptionProperty = "SDESCRIPT")
    {
        key = typeof(TDto).GetProperty(keyName)!;
        this.defaultKey = defaultKey;
        var item = new TDto(); key.SetValue(item, initialKey);
        typeof(TDto).GetProperty(descriptionProperty)!.SetValue(item, "Original <script>");
        records[initialKey] = item;
    }
    static TDto Copy(object source)
    {
        var dto = new TDto();
        foreach (var p in source.GetType().GetProperties())
            typeof(TDto).GetProperty(p.Name)?.SetValue(dto, p.GetValue(source));
        return dto;
    }
    public virtual Task<IEnumerable<TDto>> GetAllAsync() => Task.FromResult<IEnumerable<TDto>>(records.Values.ToList());
    public async Task<PagedResult<TDto>> GetListPageAsync(int page=1,string? search=null,CancellationToken cancellationToken=default,int pageSize=ListingPolicy.DefaultPageSize)
    {
        var rows=(await GetAllAsync()).Where(dto=>string.IsNullOrWhiteSpace(search) || dto.GetType().GetProperties().Any(p=>p.GetValue(dto)?.ToString()?.Contains(search,StringComparison.OrdinalIgnoreCase)==true))
            .OrderBy(dto=>key.GetValue(dto)).ToList();
        pageSize=ListingPolicy.NormalizePageSize(pageSize);
        page=(int)Math.Clamp(page,1,Math.Max(1,(rows.Count+pageSize-1L)/pageSize));
        return new(rows.Skip((page-1)*pageSize).Take(pageSize).ToList(),rows.Count,page,pageSize);
    }
    public Task<TDto?> GetByIdAsync(TKey id) => Task.FromResult(records.GetValueOrDefault(id));
    public Task<TDto> CreateAsync(TCreate create)
    {
        var dto = Copy(create);
        if (key.GetValue(dto) is not TKey id || EqualityComparer<TKey>.Default.Equals(id, default!))
            key.SetValue(dto, defaultKey);
        records[(TKey)key.GetValue(dto)!] = dto;
        return Task.FromResult(dto);
    }
    public Task<bool> UpdateAsync(TKey id, TUpdate update)
    {
        if (!records.ContainsKey(id)) return Task.FromResult(false);
        records[id] = Copy(update); return Task.FromResult(true);
    }
    public Task<bool> DeleteAsync(TKey id) => Task.FromResult(records.Remove(id));
}
sealed class NumberCatalog : MemoryCatalog<TABLE2000Dto,CreateTABLE2000Dto,UpdateTABLE2000Dto,long>, ITABLE2000Service
{
    public NumberCatalog() : base("NAPLY", 7, 42) { for(var id=100;id<=143;id++)Seed(id,"Seed "+id); }
    public Task<IEnumerable<TABLE2000Dto>> FindAsync(Expression<Func<WEBVisualTime.Entidades.Insudb.TABLE2000,bool>> predicate) => GetAllAsync();
}
sealed class StringCatalog : MemoryCatalog<TABLE999Dto,CreateTABLE999Dto,UpdateTABLE999Dto,string>, ITABLE999Service
{
    public StringCatalog() : base("SSTAT_ERROR", "A", "NEW") { }
    public Task<IEnumerable<TABLE999Dto>> FindAsync(Expression<Func<WEBVisualTime.Entidades.Insudb.TABLE999,bool>> predicate) => GetAllAsync();
}

sealed class WideUserCatalog : MemoryCatalog<APPUSERDto,CreateAPPUSERDto,UpdateAPPUSERDto,long>, IAPPUSERService
{
    public WideUserCatalog() : base("NIDUSER", 3_000_000_000L, 3_000_000_001L, "SUSERNAME") { }
    public Task<IEnumerable<APPUSERDto>> FindAsync(Expression<Func<WEBVisualTime.Entidades.Insudb.APPUSER,bool>> predicate) => GetAllAsync();
}

sealed class DuplicateFactor : MemoryCatalog<TABLE8006Dto,CreateTABLE8006Dto,UpdateTABLE8006Dto,int>, ITABLE8006Service
{
    public DuplicateFactor() : base("NTYPEAFEC",1,1) { }
    public override Task<IEnumerable<TABLE8006Dto>> GetAllAsync()=>Task.FromResult<IEnumerable<TABLE8006Dto>>(new[]{new TABLE8006Dto {NTYPEAFEC=1,SDESCRIPT="First duplicate"},new TABLE8006Dto {NTYPEAFEC=1,SDESCRIPT="Second duplicate"}});
    public Task<IEnumerable<TABLE8006Dto>> FindAsync(Expression<Func<WEBVisualTime.Entidades.Insudb.TABLE8006,bool>> predicate)=>GetAllAsync();
}
sealed class DuplicateBase : MemoryCatalog<TABLE8007Dto,CreateTABLE8007Dto,UpdateTABLE8007Dto,int>, ITABLE8007Service
{
    public DuplicateBase() : base("NAFECBASADI",1,1) { }
    public override Task<IEnumerable<TABLE8007Dto>> GetAllAsync()=>Task.FromResult<IEnumerable<TABLE8007Dto>>(new[]{new TABLE8007Dto {NAFECBASADI=1,SDESCRIPT="First duplicate"},new TABLE8007Dto {NAFECBASADI=1,SDESCRIPT="Second duplicate"}});
    public Task<IEnumerable<TABLE8007Dto>> FindAsync(Expression<Func<WEBVisualTime.Entidades.Insudb.TABLE8007,bool>> predicate)=>GetAllAsync();
}

sealed class NumberRepository : WEBVisualTime.Datos.Repositories.IRepository<WEBVisualTime.Entidades.Insudb.TABLE2000>
{
    private readonly List<WEBVisualTime.Entidades.Insudb.TABLE2000> items = new();
    public int Saves { get; private set; }
    public Task<IEnumerable<WEBVisualTime.Entidades.Insudb.TABLE2000>> GetAllAsync() => Task.FromResult<IEnumerable<WEBVisualTime.Entidades.Insudb.TABLE2000>>(items);
    public Task<WEBVisualTime.Entidades.Insudb.TABLE2000?> GetByIdAsync(object id) => Task.FromResult(items.FirstOrDefault(e => e.NAPLY == Convert.ToInt64(id)));
    public Task<IEnumerable<WEBVisualTime.Entidades.Insudb.TABLE2000>> FindAsync(Expression<Func<WEBVisualTime.Entidades.Insudb.TABLE2000,bool>> predicate) => Task.FromResult(items.Where(predicate.Compile()));
    public Task<(IReadOnlyList<WEBVisualTime.Entidades.Insudb.TABLE2000> Items,long TotalCount,int Page)> GetListPageAsync(int page,string? search=null,CancellationToken cancellationToken=default,int pageSize=ListingPolicy.DefaultPageSize)
    {
        var filtered=items.Where(e=>string.IsNullOrEmpty(search)||e.SDESCRIPT?.Contains(search)==true).OrderBy(e=>e.NAPLY).ToList();
        pageSize=ListingPolicy.NormalizePageSize(pageSize);
        return Task.FromResult(((IReadOnlyList<WEBVisualTime.Entidades.Insudb.TABLE2000>)filtered.Skip((page-1)*pageSize).Take(pageSize).ToList(),(long)filtered.Count,page));
    }
    public Task<(IReadOnlyList<WEBVisualTime.Entidades.Insudb.TABLE2000> Items,long TotalCount,int Page)> GetPageAsync(int page,int pageSize,Expression<Func<WEBVisualTime.Entidades.Insudb.TABLE2000,object>> orderBy,Expression<Func<WEBVisualTime.Entidades.Insudb.TABLE2000,bool>>? predicate=null,CancellationToken cancellationToken=default)
    {
        var filtered=predicate is null ? items : items.Where(predicate.Compile()).ToList();
        return Task.FromResult(((IReadOnlyList<WEBVisualTime.Entidades.Insudb.TABLE2000>)filtered.OrderBy(orderBy.Compile()).Skip((page-1)*pageSize).Take(pageSize).ToList(),(long)filtered.Count,page));
    }
    public Task AddAsync(WEBVisualTime.Entidades.Insudb.TABLE2000 entity) { items.Add(entity); return Task.CompletedTask; }
    public void Update(WEBVisualTime.Entidades.Insudb.TABLE2000 entity) { }
    public void Remove(WEBVisualTime.Entidades.Insudb.TABLE2000 entity) => items.Remove(entity);
    public Task<int> SaveChangesAsync() { Saves++; return Task.FromResult(1); }
}
