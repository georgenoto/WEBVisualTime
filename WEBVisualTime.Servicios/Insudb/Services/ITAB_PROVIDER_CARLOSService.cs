using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER_CARLOS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROVIDER_CARLOSService : IService<TAB_PROVIDER_CARLOSDto, CreateTAB_PROVIDER_CARLOSDto, UpdateTAB_PROVIDER_CARLOSDto, int>
{
    Task<IEnumerable<TAB_PROVIDER_CARLOSDto>> FindAsync(Expression<Func<TAB_PROVIDER_CARLOS, bool>> predicate);
}
