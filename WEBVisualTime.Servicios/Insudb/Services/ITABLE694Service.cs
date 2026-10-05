using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE694;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE694Service : IService<TABLE694Dto, CreateTABLE694Dto, UpdateTABLE694Dto, int>
{
    Task<IEnumerable<TABLE694Dto>> FindAsync(Expression<Func<TABLE694, bool>> predicate);
}
