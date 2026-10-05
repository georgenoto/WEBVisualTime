using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_RELAT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_RELATService : IService<TAB_RELATDto, CreateTAB_RELATDto, UpdateTAB_RELATDto, int>
{
    Task<IEnumerable<TAB_RELATDto>> FindAsync(Expression<Func<TAB_RELAT, bool>> predicate);
}
