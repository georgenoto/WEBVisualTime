using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_WIN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IFINANC_WINService : IService<FINANC_WINDto, CreateFINANC_WINDto, UpdateFINANC_WINDto, long>
{
    Task<IEnumerable<FINANC_WINDto>> FindAsync(Expression<Func<FINANC_WIN, bool>> predicate);
}
