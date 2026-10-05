using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIENTService : IService<CLIENTDto, CreateCLIENTDto, UpdateCLIENTDto, string>
{
    Task<IEnumerable<CLIENTDto>> FindAsync(Expression<Func<CLIENT, bool>> predicate);
}
