using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_SHORT_G;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_SHORT_GService : IService<TAB_SHORT_GDto, CreateTAB_SHORT_GDto, UpdateTAB_SHORT_GDto, string>
{
    Task<IEnumerable<TAB_SHORT_GDto>> FindAsync(Expression<Func<TAB_SHORT_G, bool>> predicate);
}
