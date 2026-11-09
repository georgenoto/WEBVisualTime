using WEBVisualTime.Entidades.ImportacionPrimas;
namespace WEBVisualTime.Web.Infrastructure;
public sealed class PrimaImportacionWorker(IServiceScopeFactory scopes,IConfiguration configuration,ILogger<PrimaImportacionWorker> logger):BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while(!stoppingToken.IsCancellationRequested)
        {
            var worked=false;
            try
            {
                if(configuration.GetValue<bool>("CargaPrimas:Habilitado"))
                {
                    using var scope=scopes.CreateScope();
                    worked=await scope.ServiceProvider.GetRequiredService<IPrimaImportacionStore>().ProcesarSiguienteAsync(stoppingToken);
                }
            }
            catch(OperationCanceledException) when(stoppingToken.IsCancellationRequested){break;}
            catch(Exception ex){logger.LogError(ex,"No se pudo procesar la cola de primas. Se reintentará la consulta.");}
            try{await Task.Delay(worked?100:5000,stoppingToken);}catch(OperationCanceledException){break;}
        }
    }
}
