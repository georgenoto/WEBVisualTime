using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINFIN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_WINFINService : IService<TAB_WINFINDto, CreateTAB_WINFINDto, UpdateTAB_WINFINDto, int>
{
    Task<IEnumerable<TAB_WINFINDto>> FindAsync(Expression<Func<TAB_WINFIN, bool>> predicate);
}
