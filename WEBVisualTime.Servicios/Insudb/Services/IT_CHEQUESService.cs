using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_CHEQUES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_CHEQUESService : IService<T_CHEQUESDto, CreateT_CHEQUESDto, UpdateT_CHEQUESDto, string>
{
    Task<IEnumerable<T_CHEQUESDto>> FindAsync(Expression<Func<T_CHEQUES, bool>> predicate);
}
