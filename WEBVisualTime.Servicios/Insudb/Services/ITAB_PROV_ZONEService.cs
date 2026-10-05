using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_ZONE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROV_ZONEService : IService<TAB_PROV_ZONEDto, CreateTAB_PROV_ZONEDto, UpdateTAB_PROV_ZONEDto, int>
{
    Task<IEnumerable<TAB_PROV_ZONEDto>> FindAsync(Expression<Func<TAB_PROV_ZONE, bool>> predicate);
}
