using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINCLA;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_WINCLAService : IService<TAB_WINCLADto, CreateTAB_WINCLADto, UpdateTAB_WINCLADto, string>
{
    Task<IEnumerable<TAB_WINCLADto>> FindAsync(Expression<Func<TAB_WINCLA, bool>> predicate);
}
