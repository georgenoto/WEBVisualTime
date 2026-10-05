using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_CESService : IService<CLAIM_CESDto, CreateCLAIM_CESDto, UpdateCLAIM_CESDto, long>
{
    Task<IEnumerable<CLAIM_CESDto>> FindAsync(Expression<Func<CLAIM_CES, bool>> predicate);
}
