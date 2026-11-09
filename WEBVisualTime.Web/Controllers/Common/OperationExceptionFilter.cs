using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using WEBVisualTime.Entidades.Common;
using WEBVisualTime.Web.Models;

namespace WEBVisualTime.Web.Controllers.Common;

public sealed class OperationExceptionFilter(ILogger<OperationExceptionFilter> logger, IModelMetadataProvider metadata) : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.ActionDescriptor is not ControllerActionDescriptor action
            || !typeof(Controller).IsAssignableFrom(action.ControllerTypeInfo)) return;
        var error = context.Exception;
        if (error is OperationCanceledException && context.HttpContext.RequestAborted.IsCancellationRequested) return;
        var (status, message) = error switch
        {
            RecordKeyException => (400, "La llave del registro está incompleta o no es válida. Vuelva al listado para seleccionar el registro."),
            DbUpdateConcurrencyException => (409, "El registro cambió o ya no existe. Vuelva a consultarlo antes de guardar."),
            DbUpdateException => (409, "No se pudo guardar. Verifique los datos y sus relaciones con otros registros."),
            DbException or TimeoutException or OperationCanceledException => (503, "No fue posible consultar la base de datos. Intente nuevamente."),
            _ => (500, "No se pudo completar la operación. Informe la referencia a soporte.")
        };
        var reference = Activity.Current?.Id ?? context.HttpContext.TraceIdentifier;
        logger.LogError(error, "Operation failed. Reference: {Reference}", reference);
        context.Result = new ViewResult
        {
            ViewName = "~/Views/Home/Error.cshtml", StatusCode = status,
            ViewData = new ViewDataDictionary<ErrorViewModel>(metadata, context.ModelState)
            { Model = new ErrorViewModel(reference, message) }
        };
        context.ExceptionHandled = true;
    }
}
