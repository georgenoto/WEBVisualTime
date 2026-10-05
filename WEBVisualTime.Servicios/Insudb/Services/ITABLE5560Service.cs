using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5560;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5560Service : IService<TABLE5560Dto, CreateTABLE5560Dto, UpdateTABLE5560Dto, int>
{
    Task<IEnumerable<TABLE5560Dto>> FindAsync(Expression<Func<TABLE5560, bool>> predicate);
}
