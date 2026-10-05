using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WAITPO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_WAITPOService : IService<TAB_WAITPODto, CreateTAB_WAITPODto, UpdateTAB_WAITPODto, int>
{
    Task<IEnumerable<TAB_WAITPODto>> FindAsync(Expression<Func<TAB_WAITPO, bool>> predicate);
}
