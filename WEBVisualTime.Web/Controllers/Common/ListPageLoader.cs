using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Entidades.Common;
using WEBVisualTime.Servicios.Services.Common;
using WEBVisualTime.Web.Models;

namespace WEBVisualTime.Web.Controllers.Common;

public static class ListPageLoader
{
    public static async Task<IActionResult> LoadAsync<TDto, TCreate, TUpdate, TKey>(Controller controller,
        IService<TDto, TCreate, TUpdate, TKey> service, int page, string? search, string view,
        CrudDefinition? definition = null)
        where TDto : class where TCreate : class where TUpdate : class
    {
        var pageSize = int.TryParse(controller.Request.Query["pageSize"], out var requestedSize)
            ? ListingPolicy.NormalizePageSize(requestedSize) : ListingPolicy.DefaultPageSize;
        page = ListingPolicy.NormalizePage(page, pageSize);
        search = ListingPolicy.NormalizeSearch(search);
        var logger = controller.HttpContext.RequestServices.GetRequiredService<ILoggerFactory>().CreateLogger("PagedListings");
        var entity = definition?.Name ?? controller.ControllerContext.ActionDescriptor.ControllerName;
        ListPageViewModel model;
        try
        {
            var result = await service.GetListPageAsync(page, search, controller.HttpContext.RequestAborted, pageSize);
            model = new()
            {
                Definition = definition, Items = result.Items.Cast<object>().ToArray(),
                TotalCount = result.TotalCount, Page = result.Page, PageSize = result.PageSize, Search = search
            };
            logger.LogInformation("{Entity} loaded {Count} rows on page {Page}; {Total} matches.", entity, model.Items.Count, model.Page, model.TotalCount);
        }
        catch (OperationCanceledException) when (controller.HttpContext.RequestAborted.IsCancellationRequested)
        {
            return new EmptyResult();
        }
        catch (Exception error)
        {
            var reference = Activity.Current?.Id ?? controller.HttpContext.TraceIdentifier;
            logger.LogError(error, "Failed to load {Entity}. Reference: {Reference}", entity, reference);
            controller.Response.StatusCode = error is DbException or TimeoutException or OperationCanceledException ? 503 : 500;
            model = new()
            {
                Definition = definition, Page = page, PageSize = pageSize, Search = search, ErrorReference = reference,
                ErrorMessage = error switch
                {
                    TimeoutException or OperationCanceledException => "La consulta tardó demasiado. Intente nuevamente o use un criterio de búsqueda más específico.",
                    DbException => "No fue posible consultar la base de datos. Intente nuevamente.",
                    _ => "No se pudo cargar el listado. Informe esta referencia al equipo de soporte."
                }
            };
        }
        controller.ViewData["Title"] = definition?.Name ?? entity;
        return controller.View(view, model);
    }
}
