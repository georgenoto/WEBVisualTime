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

// 4. Add Controllers & Swagger
builder.Services.AddControllers();
builder.Services.AddProblemDetails();
builder.Services.AddExceptionHandler<WEBVisualTime.WebApi.Infrastructure.ApiExceptionHandler>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
});

var app = builder.Build();

// Configure HTTP Request Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
