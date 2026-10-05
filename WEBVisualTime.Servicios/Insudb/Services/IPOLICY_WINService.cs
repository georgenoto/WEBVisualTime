using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_WIN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPOLICY_WINService : IService<POLICY_WINDto, CreatePOLICY_WINDto, UpdatePOLICY_WINDto, string>
{
    Task<IEnumerable<POLICY_WINDto>> FindAsync(Expression<Func<POLICY_WIN, bool>> predicate);
}
