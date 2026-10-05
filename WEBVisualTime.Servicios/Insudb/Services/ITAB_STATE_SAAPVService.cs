using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_STATE_SAAPV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_STATE_SAAPVService : IService<TAB_STATE_SAAPVDto, CreateTAB_STATE_SAAPVDto, UpdateTAB_STATE_SAAPVDto, int>
{
    Task<IEnumerable<TAB_STATE_SAAPVDto>> FindAsync(Expression<Func<TAB_STATE_SAAPV, bool>> predicate);
}
