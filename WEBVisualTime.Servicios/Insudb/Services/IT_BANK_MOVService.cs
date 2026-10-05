using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_BANK_MOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_BANK_MOVService : IService<T_BANK_MOVDto, CreateT_BANK_MOVDto, UpdateT_BANK_MOVDto, long>
{
    Task<IEnumerable<T_BANK_MOVDto>> FindAsync(Expression<Func<T_BANK_MOV, bool>> predicate);
}
