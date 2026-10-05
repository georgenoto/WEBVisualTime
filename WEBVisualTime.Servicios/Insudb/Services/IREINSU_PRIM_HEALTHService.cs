using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSU_PRIM_HEALTH;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREINSU_PRIM_HEALTHService : IService<REINSU_PRIM_HEALTHDto, CreateREINSU_PRIM_HEALTHDto, UpdateREINSU_PRIM_HEALTHDto, int>
{
    Task<IEnumerable<REINSU_PRIM_HEALTHDto>> FindAsync(Expression<Func<REINSU_PRIM_HEALTH, bool>> predicate);
}
