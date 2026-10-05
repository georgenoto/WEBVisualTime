using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RETENTIONCOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IRETENTIONCOVService : IService<RETENTIONCOVDto, CreateRETENTIONCOVDto, UpdateRETENTIONCOVDto, int>
{
    Task<IEnumerable<RETENTIONCOVDto>> FindAsync(Expression<Func<RETENTIONCOV, bool>> predicate);
}
