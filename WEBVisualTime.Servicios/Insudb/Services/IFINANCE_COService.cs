using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANCE_CO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IFINANCE_COService : IService<FINANCE_CODto, CreateFINANCE_CODto, UpdateFINANCE_CODto, string>
{
    Task<IEnumerable<FINANCE_CODto>> FindAsync(Expression<Func<FINANCE_CO, bool>> predicate);
}
