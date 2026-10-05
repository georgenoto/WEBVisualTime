using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINPOL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_WINPOLService : IService<TAB_WINPOLDto, CreateTAB_WINPOLDto, UpdateTAB_WINPOLDto, string>
{
    Task<IEnumerable<TAB_WINPOLDto>> FindAsync(Expression<Func<TAB_WINPOL, bool>> predicate);
}
