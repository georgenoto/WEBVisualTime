using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_GROUP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROV_GROUPService : IService<TAB_PROV_GROUPDto, CreateTAB_PROV_GROUPDto, UpdateTAB_PROV_GROUPDto, int>
{
    Task<IEnumerable<TAB_PROV_GROUPDto>> FindAsync(Expression<Func<TAB_PROV_GROUP, bool>> predicate);
}
