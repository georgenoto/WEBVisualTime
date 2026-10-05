using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_DELTA_BASELINE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPOLICY_DELTA_BASELINEService : IService<POLICY_DELTA_BASELINEDto, CreatePOLICY_DELTA_BASELINEDto, UpdatePOLICY_DELTA_BASELINEDto, string>
{
    Task<IEnumerable<POLICY_DELTA_BASELINEDto>> FindAsync(Expression<Func<POLICY_DELTA_BASELINE, bool>> predicate);
}
