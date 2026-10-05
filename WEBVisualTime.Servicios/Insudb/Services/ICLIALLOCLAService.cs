using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIALLOCLA;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIALLOCLAService : IService<CLIALLOCLADto, CreateCLIALLOCLADto, UpdateCLIALLOCLADto, int>
{
    Task<IEnumerable<CLIALLOCLADto>> FindAsync(Expression<Func<CLIALLOCLA, bool>> predicate);
}
