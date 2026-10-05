using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_BKACCOUNT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROV_BKACCOUNTService : IService<TAB_PROV_BKACCOUNTDto, CreateTAB_PROV_BKACCOUNTDto, UpdateTAB_PROV_BKACCOUNTDto, int>
{
    Task<IEnumerable<TAB_PROV_BKACCOUNTDto>> FindAsync(Expression<Func<TAB_PROV_BKACCOUNT, bool>> predicate);
}
