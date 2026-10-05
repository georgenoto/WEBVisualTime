using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_CONCLASS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICASH_CONCLASSService : IService<CASH_CONCLASSDto, CreateCASH_CONCLASSDto, UpdateCASH_CONCLASSDto, int>
{
    Task<IEnumerable<CASH_CONCLASSDto>> FindAsync(Expression<Func<CASH_CONCLASS, bool>> predicate);
}
