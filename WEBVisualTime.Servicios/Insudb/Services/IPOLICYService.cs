using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPOLICYService : IService<POLICYDto, CreatePOLICYDto, UpdatePOLICYDto, string>
{
    Task<IEnumerable<POLICYDto>> FindAsync(Expression<Func<POLICY, bool>> predicate);
}
