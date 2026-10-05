using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5567;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5567Service : IService<TABLE5567Dto, CreateTABLE5567Dto, UpdateTABLE5567Dto, int>
{
    Task<IEnumerable<TABLE5567Dto>> FindAsync(Expression<Func<TABLE5567, bool>> predicate);
}
