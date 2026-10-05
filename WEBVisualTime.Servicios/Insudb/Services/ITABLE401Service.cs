using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE401;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE401Service : IService<TABLE401Dto, CreateTABLE401Dto, UpdateTABLE401Dto, int>
{
    Task<IEnumerable<TABLE401Dto>> FindAsync(Expression<Func<TABLE401, bool>> predicate);
}
