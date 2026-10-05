using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPOLICY_HISService : IService<POLICY_HISDto, CreatePOLICY_HISDto, UpdatePOLICY_HISDto, string>
{
    Task<IEnumerable<POLICY_HISDto>> FindAsync(Expression<Func<POLICY_HIS, bool>> predicate);
}
