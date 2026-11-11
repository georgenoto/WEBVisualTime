using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Entidades.ImportacionPrimas;
using WEBVisualTime.Servicios.ImportacionPrimas;
using WEBVisualTime.Web.Models;

namespace WEBVisualTime.Web.Controllers;

public sealed class CargarPrimasController(IPrimaImportacionStore store, PrimaExcelReader reader,
    IConfiguration configuration, ILogger<CargarPrimasController> logger) : Controller
{
    bool Enabled => configuration.GetValue<bool>("CargaPrimas:Habilitado");
    void EnsureEnabled() { if (!Enabled) throw new ArgumentException("El módulo requiere instalar las tablas de trabajo y habilitar CargaPrimas:Habilitado en la configuración del servidor."); }
    void Error(Exception ex)
    {
        logger.LogError(ex,"Carga de primas: {TraceId}",HttpContext.TraceIdentifier);
        TempData["PrimasError"] = ex is ArgumentException ? ex.Message : "No se pudo completar la operación. Referencia de soporte: " + HttpContext.TraceIdentifier;
    }
    public async Task<IActionResult> Index(CancellationToken ct)
    {
        var model = new PrimaImportacionViewModel { Habilitado=Enabled };
        if (Enabled) try { model.Recientes=await store.RecientesAsync(ct); } catch(Exception ex) { Error(ex); }
        return View(model);
    }
    [HttpPost, ValidateAntiForgeryToken, RequestSizeLimit(22 * 1024 * 1024)]
    [RequestFormLimits(MultipartBodyLengthLimit=22 * 1024 * 1024)]
    public async Task<IActionResult> Importar(IFormFile? archivo,CancellationToken ct)
    {
        try
        {
            EnsureEnabled();
            if(archivo is null || archivo.Length>PrimaExcelReader.MaxBytes) throw new ArgumentException("Seleccione un Excel de hasta 20 MB.");
            using var ms=new MemoryStream(); await archivo.CopyToAsync(ms,ct);
            var original=ms.ToArray();var documento=reader.Leer(original,archivo.FileName);
            var id=await store.CrearAsync(documento,original,ct);
            return RedirectToAction(nameof(Seleccionar),new{id});
        }
        catch(Exception ex) when(ex is not OperationCanceledException) { Error(ex); return RedirectToAction(nameof(Index)); }
    }
    public async Task<IActionResult> Seleccionar(string id,CancellationToken ct)
    {
        try
        {
            EnsureEnabled(); var status=await store.EstadoAsync(id,ct);
            if(status.Estado is not ("BORRADOR" or "REVISADO")) return RedirectToAction(nameof(Progreso),new{id});
            return View(new PrimaImportacionViewModel{Id=id,Documento=await store.DocumentoAsync(id,ct),Catalogos=await store.CatalogosAsync(ct),Plan=await store.PlanAsync(id,ct)});
        }
        catch(Exception ex) when(ex is not OperationCanceledException) { Error(ex); return RedirectToAction(nameof(Index)); }
    }
    [HttpPost,ValidateAntiForgeryToken]
    public async Task<IActionResult> Preparar(string id,int[] roles,int[] regionales,int usuario,string? fechaEfecto,CancellationToken ct)
    {
        try
        {
            EnsureEnabled();
            if (!DateTime.TryParseExact(fechaEfecto,"yyyy-MM-dd",CultureInfo.InvariantCulture,DateTimeStyles.None,out var efecto))
                throw new ArgumentException("Seleccione la fecha de efecto de las nuevas tarifas.");
            var plan=new PrimaPlan(await store.DocumentoAsync(id,ct),roles.Distinct().Order().ToArray(),regionales.Distinct().Order().ToArray(),usuario,efecto);
            PrimaExcelReader.ValidarPlan(plan); await store.ConfigurarAsync(id,plan,ct);
            return RedirectToAction(nameof(Revisar),new{id});
        }
        catch(Exception ex) when(ex is not OperationCanceledException) { Error(ex); return RedirectToAction(nameof(Seleccionar),new{id}); }
    }
    public async Task<IActionResult> Revisar(string id,int pagina=1,CancellationToken ct=default)
    {
        try
        {
            EnsureEnabled(); var plan=await store.PlanAsync(id,ct)??throw new ArgumentException("Primero seleccione roles y regionales.");
            var state=await store.EstadoAsync(id,ct);
            if(state.Estado!="REVISADO") return RedirectToAction(nameof(Progreso),new{id});
            var hash=Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(plan))));
            return View(new PrimaImportacionViewModel{Id=id,Plan=plan,Revision=hash,Pagina=Math.Clamp(pagina,1,Math.Max(1,(int)((plan.Total+49)/50)))});
        }
        catch(Exception ex) when(ex is not OperationCanceledException) { Error(ex); return RedirectToAction(nameof(Index)); }
    }
    [HttpPost,ValidateAntiForgeryToken]
    public async Task<IActionResult> Ejecutar(string id,string revision,bool confirmar,CancellationToken ct)
    {
        try { EnsureEnabled(); if(!confirmar)throw new ArgumentException("Confirme la revisión antes de ejecutar."); await store.EncolarAsync(id,revision,ct); }
        catch(Exception ex) when(ex is not OperationCanceledException) { Error(ex); }
        return RedirectToAction(nameof(Progreso),new{id});
    }
    public async Task<IActionResult> Progreso(string id,CancellationToken ct)
    {
        try { EnsureEnabled(); var estado=await store.EstadoAsync(id,ct);return View(new PrimaImportacionViewModel{Id=id,Estado=estado,Plan=estado.Estado=="COMPLETADO"?await store.PlanAsync(id,ct):null}); }
        catch(Exception ex) when(ex is not OperationCanceledException) { Error(ex); return RedirectToAction(nameof(Index)); }
    }
    public async Task<IActionResult> Estado(string id,CancellationToken ct)
    {
        if(!Enabled)return NotFound();
        try{return Json(await store.EstadoAsync(id,ct));}catch(Exception ex) when(ex is not OperationCanceledException){logger.LogError(ex,"Estado de importación {Id}",id);return StatusCode(503,new{error="No se pudo consultar el progreso. Puede recargar esta página."});}
    }
    [HttpPost,ValidateAntiForgeryToken]
    public async Task<IActionResult> Pausar(string id,CancellationToken ct)
    {
        try{EnsureEnabled();await store.PausarAsync(id,ct);}catch(Exception ex) when(ex is not OperationCanceledException){Error(ex);}
        return RedirectToAction(nameof(Progreso),new{id});
    }
    [HttpPost,ValidateAntiForgeryToken]
    public async Task<IActionResult> CambiarConfiguracion(string id,CancellationToken ct)
    {
        try{EnsureEnabled();await store.EditarAsync(id,ct);return RedirectToAction(nameof(Seleccionar),new{id});}
        catch(Exception ex) when(ex is not OperationCanceledException){Error(ex);return RedirectToAction(nameof(Progreso),new{id});}
    }
    [HttpPost,ValidateAntiForgeryToken]
    public async Task<IActionResult> Reanudar(string id,CancellationToken ct)
    {
        try{EnsureEnabled();await store.ReanudarAsync(id,ct);}catch(Exception ex) when(ex is not OperationCanceledException){Error(ex);}
        return RedirectToAction(nameof(Progreso),new{id});
    }
    public async Task<IActionResult> DescargarInforme(string id,CancellationToken ct)
    {
        EnsureEnabled();var status=await store.EstadoAsync(id,ct);var plan=await store.PlanAsync(id,ct);
        return File(JsonSerializer.SerializeToUtf8Bytes(new{Estado=status,TarifasAnterioresCerradas=plan?.TarifasAnterioresCerradas,Revision=plan is null?null:new{Roles=plan.Roles,Regionales=plan.Regionales,UsuarioDeclarado=plan.Usuario,FechaEfecto=plan.FechaEfecto,CierreAnteriores=plan.FechaEfecto.HasValue,Huella=plan.Documento.Huella,Filas=plan.Documento.Filas.Count}},new JsonSerializerOptions{WriteIndented=true}),"application/json",$"primas-{id}.json");
    }
}
