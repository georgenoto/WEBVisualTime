using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CASE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_CASEService : IService<CLAIM_CASEDto, CreateCLAIM_CASEDto, UpdateCLAIM_CASEDto, long>
{
    Task<IEnumerable<CLAIM_CASEDto>> FindAsync(Expression<Func<CLAIM_CASE, bool>> predicate);
}
