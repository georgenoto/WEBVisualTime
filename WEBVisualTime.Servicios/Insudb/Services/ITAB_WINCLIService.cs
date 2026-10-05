using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINCLI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_WINCLIService : IService<TAB_WINCLIDto, CreateTAB_WINCLIDto, UpdateTAB_WINCLIDto, string>
{
    Task<IEnumerable<TAB_WINCLIDto>> FindAsync(Expression<Func<TAB_WINCLI, bool>> predicate);
}
