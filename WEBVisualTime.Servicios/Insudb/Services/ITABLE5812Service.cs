using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5812;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5812Service : IService<TABLE5812Dto, CreateTABLE5812Dto, UpdateTABLE5812Dto, int>
{
    Task<IEnumerable<TABLE5812Dto>> FindAsync(Expression<Func<TABLE5812, bool>> predicate);
}
