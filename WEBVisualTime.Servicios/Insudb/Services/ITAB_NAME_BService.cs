using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_NAME_B;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_NAME_BService : IService<TAB_NAME_BDto, CreateTAB_NAME_BDto, UpdateTAB_NAME_BDto, int>
{
    Task<IEnumerable<TAB_NAME_BDto>> FindAsync(Expression<Func<TAB_NAME_B, bool>> predicate);
}
