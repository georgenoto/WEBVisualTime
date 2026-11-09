using Microsoft.EntityFrameworkCore;
using WEBVisualTime.Datos;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios;

var builder = WebApplication.CreateBuilder(args);

// 1. Add DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("ConnectionString 'DefaultConnection' not found.");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(connectionString));

// 2. Register Repositories
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// 3. Register Application Services
builder.Services.AddVisualTimeServices();
builder.Services.AddScoped<WEBVisualTime.Entidades.ImportacionPrimas.IPrimaImportacionStore, WEBVisualTime.Datos.ImportacionPrimas.OraclePrimaImportacionStore>();
builder.Services.AddSingleton<WEBVisualTime.Servicios.ImportacionPrimas.PrimaExcelReader>();
builder.Services.AddHostedService<WEBVisualTime.Web.Infrastructure.PrimaImportacionWorker>();

// 4. Add MVC Controllers and Views
builder.Services.AddControllersWithViews(options =>
    options.Filters.Add<WEBVisualTime.Web.Controllers.Common.OperationExceptionFilter>());

var app = builder.Build();

// Configure HTTP Request Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
