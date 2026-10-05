using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5709;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5709Service : IService<TABLE5709Dto, CreateTABLE5709Dto, UpdateTABLE5709Dto, long>
{
    Task<IEnumerable<TABLE5709Dto>> FindAsync(Expression<Func<TABLE5709, bool>> predicate);
}
