using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_CLAUSE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_CLAUSEService : IService<TAB_CLAUSEDto, CreateTAB_CLAUSEDto, UpdateTAB_CLAUSEDto, string>
{
    Task<IEnumerable<TAB_CLAUSEDto>> FindAsync(Expression<Func<TAB_CLAUSE, bool>> predicate);
}
