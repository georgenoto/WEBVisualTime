using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_DRA;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IFINANC_DRAService : IService<FINANC_DRADto, CreateFINANC_DRADto, UpdateFINANC_DRADto, long>
{
    Task<IEnumerable<FINANC_DRADto>> FindAsync(Expression<Func<FINANC_DRA, bool>> predicate);
}
