using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_COM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IFINANC_COMService : IService<FINANC_COMDto, CreateFINANC_COMDto, UpdateFINANC_COMDto, long>
{
    Task<IEnumerable<FINANC_COMDto>> FindAsync(Expression<Func<FINANC_COM, bool>> predicate);
}
