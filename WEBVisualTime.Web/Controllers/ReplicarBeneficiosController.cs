using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Entidades.ReplicaBeneficios;
using WEBVisualTime.Web.Models;
namespace WEBVisualTime.Web.Controllers;

public sealed class ReplicarBeneficiosController(IReplicaBeneficiosStore store, IConfiguration config, ILogger<ReplicarBeneficiosController> logger) : Controller
{
    bool Enabled => config.GetValue<bool>("ReplicaBeneficios:Habilitado");
    void Ensure() { if (!Enabled) throw new ArgumentException("Instale las tablas de trabajo y habilite ReplicaBeneficios:Habilitado en el servidor."); }
    void Error(Exception ex)
    {
        logger.LogError(ex, "Réplica de beneficios {Referencia}", HttpContext.TraceIdentifier);
        TempData["BeneficiosError"] = ex is ArgumentException ? ex.Message : "No se pudo completar la operación. Referencia: " + HttpContext.TraceIdentifier;
    }
    public async Task<IActionResult> Index(int producto = 0, string? id = null, CancellationToken ct = default)
    {
        var m = new ReplicaBeneficiosViewModel { Habilitado = Enabled, Producto = producto };
        if (Enabled) try
        {
            if (id is not null)
            {
                m.Operacion = await store.EstadoAsync(id, ct);
                if (m.Operacion.Estado != "REVISADO") return RedirectToAction(nameof(Operacion), new { id });
                m.Producto = m.Operacion.Plan.Producto;
            }
            m.Productos = await store.ProductosAsync(ct); m.Recientes = await store.RecientesAsync(ct);
            if (m.Producto > 0) m.Modulos = await store.ModulosAsync(m.Producto, ct);
        }
            catch (Exception ex) when (ex is not OperationCanceledException) { Error(ex); }
        return View(m);
    }
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Preparar(int producto, int moduloBase, int[] destinos, int usuario, string? id, string? revision, CancellationToken ct)
    {
        try
        {
            Ensure(); if (!ModelState.IsValid) throw new ArgumentException("Revise los códigos seleccionados.");
            var plan = new BeneficioPlan(5, producto, moduloBase, destinos, usuario);
            if (id is null) id = await store.CrearAsync(plan, ct);
            else await store.EditarAsync(id, revision ?? "", plan, ct);
            return RedirectToAction(nameof(Operacion), new { id });
        }
        catch (Exception ex) when (ex is not OperationCanceledException) { Error(ex); return RedirectToAction(nameof(Index), new { producto, id }); }
    }
    public async Task<IActionResult> Operacion(string id, CancellationToken ct)
    {
        try { Ensure(); return View(new ReplicaBeneficiosViewModel { Operacion = await store.EstadoAsync(id, ct) }); }
        catch (Exception ex) when (ex is not OperationCanceledException) { Error(ex); return RedirectToAction(nameof(Index)); }
    }
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Accion(string id, string accion, string? revision, bool confirmar, CancellationToken ct)
    {
        try
        {
            Ensure();
            if (accion is "ejecutar" or "restaurar" && !confirmar) throw new ArgumentException("Confirme el alcance antes de continuar.");
            await store.AccionAsync(id, accion, revision, ct);
        }
        catch (Exception ex) when (ex is not OperationCanceledException) { Error(ex); }
        return RedirectToAction(nameof(Operacion), new { id });
    }
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public async Task<IActionResult> Estado(string id, CancellationToken ct)
    {
        if (!Enabled) return NotFound();
        try { var s = await store.EstadoAsync(id, ct); return Json(new { s.Estado, s.Preparados }); }
        catch (Exception ex) when (ex is not OperationCanceledException)
        { logger.LogError(ex, "Consulta de progreso de beneficios {Id}", id); return StatusCode(503); }
    }
    public async Task<IActionResult> Informe(string id, CancellationToken ct)
    {
        Ensure(); var s = await store.EstadoAsync(id, ct);
        return File(JsonSerializer.SerializeToUtf8Bytes(s, new JsonSerializerOptions { WriteIndented = true }), "application/json", $"beneficios-{s.Id}.json");
    }
}
