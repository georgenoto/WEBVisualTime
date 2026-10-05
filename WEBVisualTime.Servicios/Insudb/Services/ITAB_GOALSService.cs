using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_GOALS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_GOALSService : IService<TAB_GOALSDto, CreateTAB_GOALSDto, UpdateTAB_GOALSDto, int>
{
    Task<IEnumerable<TAB_GOALSDto>> FindAsync(Expression<Func<TAB_GOALS, bool>> predicate);
}
