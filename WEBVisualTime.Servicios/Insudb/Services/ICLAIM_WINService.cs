using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_WIN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_WINService : IService<CLAIM_WINDto, CreateCLAIM_WINDto, UpdateCLAIM_WINDto, long>
{
    Task<IEnumerable<CLAIM_WINDto>> FindAsync(Expression<Func<CLAIM_WIN, bool>> predicate);
}
