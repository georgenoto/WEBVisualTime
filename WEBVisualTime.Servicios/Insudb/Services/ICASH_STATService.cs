using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_STAT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICASH_STATService : IService<CASH_STATDto, CreateCASH_STATDto, UpdateCASH_STATDto, int>
{
    Task<IEnumerable<CASH_STATDto>> FindAsync(Expression<Func<CASH_STAT, bool>> predicate);
}
