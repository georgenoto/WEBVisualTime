using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIALLOPRO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIALLOPROService : IService<CLIALLOPRODto, CreateCLIALLOPRODto, UpdateCLIALLOPRODto, string>
{
    Task<IEnumerable<CLIALLOPRODto>> FindAsync(Expression<Func<CLIALLOPRO, bool>> predicate);
}
