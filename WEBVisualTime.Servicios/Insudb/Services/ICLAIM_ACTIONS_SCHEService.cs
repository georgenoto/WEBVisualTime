using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ACTIONS_SCHE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_ACTIONS_SCHEService : IService<CLAIM_ACTIONS_SCHEDto, CreateCLAIM_ACTIONS_SCHEDto, UpdateCLAIM_ACTIONS_SCHEDto, string>
{
    Task<IEnumerable<CLAIM_ACTIONS_SCHEDto>> FindAsync(Expression<Func<CLAIM_ACTIONS_SCHE, bool>> predicate);
}
