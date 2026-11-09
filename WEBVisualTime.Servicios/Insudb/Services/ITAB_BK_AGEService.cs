using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_BK_AGE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_BK_AGEService : IService<TAB_BK_AGEDto, CreateTAB_BK_AGEDto, UpdateTAB_BK_AGEDto, string>
{
    Task<IEnumerable<TAB_BK_AGEDto>> FindAsync(Expression<Func<TAB_BK_AGE, bool>> predicate);
}
