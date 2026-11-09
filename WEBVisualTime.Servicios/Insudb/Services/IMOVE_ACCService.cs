using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MOVE_ACC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMOVE_ACCService : IService<MOVE_ACCDto, CreateMOVE_ACCDto, UpdateMOVE_ACCDto, string>
{
    Task<IEnumerable<MOVE_ACCDto>> FindAsync(Expression<Func<MOVE_ACC, bool>> predicate);
}
