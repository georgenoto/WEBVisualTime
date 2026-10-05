using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_CL_OPE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_CL_OPEService : IService<TAB_CL_OPEDto, CreateTAB_CL_OPEDto, UpdateTAB_CL_OPEDto, int>
{
    Task<IEnumerable<TAB_CL_OPEDto>> FindAsync(Expression<Func<TAB_CL_OPE, bool>> predicate);
}
