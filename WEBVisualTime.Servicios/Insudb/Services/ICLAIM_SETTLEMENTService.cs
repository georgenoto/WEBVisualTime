using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETTLEMENT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_SETTLEMENTService : IService<CLAIM_SETTLEMENTDto, CreateCLAIM_SETTLEMENTDto, UpdateCLAIM_SETTLEMENTDto, long>
{
    Task<IEnumerable<CLAIM_SETTLEMENTDto>> FindAsync(Expression<Func<CLAIM_SETTLEMENT, bool>> predicate);
}
