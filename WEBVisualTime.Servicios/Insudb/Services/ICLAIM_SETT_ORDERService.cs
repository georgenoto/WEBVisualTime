using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_ORDER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_SETT_ORDERService : IService<CLAIM_SETT_ORDERDto, CreateCLAIM_SETT_ORDERDto, UpdateCLAIM_SETT_ORDERDto, string>
{
    Task<IEnumerable<CLAIM_SETT_ORDERDto>> FindAsync(Expression<Func<CLAIM_SETT_ORDER, bool>> predicate);
}
