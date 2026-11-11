using WEBVisualTime.Entidades.ReplicaBeneficios;
namespace WEBVisualTime.Web.Infrastructure;

public sealed class ReplicaBeneficiosWorker(IServiceScopeFactory scopes, IConfiguration config, ILogger<ReplicaBeneficiosWorker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var worked = false;
            try
            {
                if (config.GetValue<bool>("ReplicaBeneficios:Habilitado"))
                { using var scope = scopes.CreateScope(); worked = await scope.ServiceProvider.GetRequiredService<IReplicaBeneficiosStore>().ProcesarAsync(stoppingToken); }
            }
            catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested) { break; }
            catch (Exception ex) { logger.LogError(ex, "No se pudo procesar la réplica de beneficios; se volverá a consultar el estado persistente."); }
            try { await Task.Delay(worked ? 100 : 5000, stoppingToken); } catch (OperationCanceledException) { break; }
        }
    }
}
