using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_FEES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROV_FEESService : IService<TAB_PROV_FEESDto, CreateTAB_PROV_FEESDto, UpdateTAB_PROV_FEESDto, string>
{
    Task<IEnumerable<TAB_PROV_FEESDto>> FindAsync(Expression<Func<TAB_PROV_FEES, bool>> predicate);
}
