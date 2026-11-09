using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_BILL_I;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_BILL_IService : IService<TAB_BILL_IDto, CreateTAB_BILL_IDto, UpdateTAB_BILL_IDto, string>
{
    Task<IEnumerable<TAB_BILL_IDto>> FindAsync(Expression<Func<TAB_BILL_I, bool>> predicate);
}
