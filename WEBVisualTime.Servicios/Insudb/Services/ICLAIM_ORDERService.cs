using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ORDER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_ORDERService : IService<CLAIM_ORDERDto, CreateCLAIM_ORDERDto, UpdateCLAIM_ORDERDto, long>
{
    Task<IEnumerable<CLAIM_ORDERDto>> FindAsync(Expression<Func<CLAIM_ORDER, bool>> predicate);
}
