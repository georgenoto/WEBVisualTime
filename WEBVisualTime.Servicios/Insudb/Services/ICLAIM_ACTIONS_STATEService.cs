using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ACTIONS_STATE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_ACTIONS_STATEService : IService<CLAIM_ACTIONS_STATEDto, CreateCLAIM_ACTIONS_STATEDto, UpdateCLAIM_ACTIONS_STATEDto, string>
{
    Task<IEnumerable<CLAIM_ACTIONS_STATEDto>> FindAsync(Expression<Func<CLAIM_ACTIONS_STATE, bool>> predicate);
}
