using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_ERR_INTERFACE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_ERR_INTERFACEService : IService<T_ERR_INTERFACEDto, CreateT_ERR_INTERFACEDto, UpdateT_ERR_INTERFACEDto, string>
{
    Task<IEnumerable<T_ERR_INTERFACEDto>> FindAsync(Expression<Func<T_ERR_INTERFACE, bool>> predicate);
}
