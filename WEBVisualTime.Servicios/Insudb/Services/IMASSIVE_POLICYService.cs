using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_POLICY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASSIVE_POLICYService : IService<MASSIVE_POLICYDto, CreateMASSIVE_POLICYDto, UpdateMASSIVE_POLICYDto, string>
{
    Task<IEnumerable<MASSIVE_POLICYDto>> FindAsync(Expression<Func<MASSIVE_POLICY, bool>> predicate);
}
