using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_INTERFACE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_INTERFACEService : IService<T_INTERFACEDto, CreateT_INTERFACEDto, UpdateT_INTERFACEDto, string>
{
    Task<IEnumerable<T_INTERFACEDto>> FindAsync(Expression<Func<T_INTERFACE, bool>> predicate);
}
