using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_ERR_MASSIVE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_ERR_MASSIVEService : IService<T_ERR_MASSIVEDto, CreateT_ERR_MASSIVEDto, UpdateT_ERR_MASSIVEDto, string>
{
    Task<IEnumerable<T_ERR_MASSIVEDto>> FindAsync(Expression<Func<T_ERR_MASSIVE, bool>> predicate);
}
