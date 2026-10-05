using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DISEX_INT_M;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDISEX_INT_MService : IService<DISEX_INT_MDto, CreateDISEX_INT_MDto, UpdateDISEX_INT_MDto, int>
{
    Task<IEnumerable<DISEX_INT_MDto>> FindAsync(Expression<Func<DISEX_INT_M, bool>> predicate);
}
