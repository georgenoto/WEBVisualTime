using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_STAFF;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROV_STAFFService : IService<TAB_PROV_STAFFDto, CreateTAB_PROV_STAFFDto, UpdateTAB_PROV_STAFFDto, string>
{
    Task<IEnumerable<TAB_PROV_STAFFDto>> FindAsync(Expression<Func<TAB_PROV_STAFF, bool>> predicate);
}
