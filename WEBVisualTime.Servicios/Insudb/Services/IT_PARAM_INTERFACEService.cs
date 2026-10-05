using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_PARAM_INTERFACE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_PARAM_INTERFACEService : IService<T_PARAM_INTERFACEDto, CreateT_PARAM_INTERFACEDto, UpdateT_PARAM_INTERFACEDto, string>
{
    Task<IEnumerable<T_PARAM_INTERFACEDto>> FindAsync(Expression<Func<T_PARAM_INTERFACE, bool>> predicate);
}
