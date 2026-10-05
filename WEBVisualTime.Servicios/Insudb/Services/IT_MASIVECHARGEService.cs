using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_MASIVECHARGE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_MASIVECHARGEService : IService<T_MASIVECHARGEDto, CreateT_MASIVECHARGEDto, UpdateT_MASIVECHARGEDto, string>
{
    Task<IEnumerable<T_MASIVECHARGEDto>> FindAsync(Expression<Func<T_MASIVECHARGE, bool>> predicate);
}
