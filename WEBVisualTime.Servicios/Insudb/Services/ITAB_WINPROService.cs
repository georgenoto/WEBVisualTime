using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINPRO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_WINPROService : IService<TAB_WINPRODto, CreateTAB_WINPRODto, UpdateTAB_WINPRODto, string>
{
    Task<IEnumerable<TAB_WINPRODto>> FindAsync(Expression<Func<TAB_WINPRO, bool>> predicate);
}
