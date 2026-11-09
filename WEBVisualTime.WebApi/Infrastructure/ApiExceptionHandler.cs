using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBVisualTime.Entidades.Common;

namespace WEBVisualTime.WebApi.Infrastructure;

public sealed class ApiExceptionHandler(ILogger<ApiExceptionHandler> logger, IProblemDetailsService problems) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext context, Exception error, CancellationToken cancellationToken)
    {
        if (error is OperationCanceledException && context.RequestAborted.IsCancellationRequested) return false;
        var (status, title) = error switch
        {
            RecordKeyException => (400, "La llave del registro no es válida. Utilice la identificación completa recibida en el listado."),
            DbUpdateConcurrencyException => (409, "El registro cambió o ya no existe. Consulte nuevamente antes de guardar."),
            DbUpdateException => (409, "No se pudo guardar el registro. Verifique sus datos y relaciones."),
            DbException or TimeoutException or OperationCanceledException => (503, "No fue posible consultar la base de datos. Intente nuevamente."),
            _ => (500, "No se pudo completar la operación. Informe la referencia a soporte.")
        };
        var reference = Activity.Current?.Id ?? context.TraceIdentifier;
        logger.LogError(error, "Request failed. Reference: {Reference}", reference);
        context.Response.StatusCode = status;
        var details = new ProblemDetails { Status = status, Title = title, Instance = context.Request.Path };
        details.Extensions["traceId"] = reference;
        if (!await problems.TryWriteAsync(new ProblemDetailsContext { HttpContext = context, ProblemDetails = details }))
            await context.Response.WriteAsJsonAsync(details, cancellationToken);
        return true;
    }
}
