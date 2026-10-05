using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TYPERR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_TYPERRService : IService<TAB_TYPERRDto, CreateTAB_TYPERRDto, UpdateTAB_TYPERRDto, int>
{
    Task<IEnumerable<TAB_TYPERRDto>> FindAsync(Expression<Func<TAB_TYPERR, bool>> predicate);
}
