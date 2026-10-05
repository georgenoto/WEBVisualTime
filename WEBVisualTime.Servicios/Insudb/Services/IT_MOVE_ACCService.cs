using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_MOVE_ACC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_MOVE_ACCService : IService<T_MOVE_ACCDto, CreateT_MOVE_ACCDto, UpdateT_MOVE_ACCDto, long>
{
    Task<IEnumerable<T_MOVE_ACCDto>> FindAsync(Expression<Func<T_MOVE_ACC, bool>> predicate);
}
