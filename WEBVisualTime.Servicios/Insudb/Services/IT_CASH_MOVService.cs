using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_CASH_MOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_CASH_MOVService : IService<T_CASH_MOVDto, CreateT_CASH_MOVDto, UpdateT_CASH_MOVDto, long>
{
    Task<IEnumerable<T_CASH_MOVDto>> FindAsync(Expression<Func<T_CASH_MOV, bool>> predicate);
}
