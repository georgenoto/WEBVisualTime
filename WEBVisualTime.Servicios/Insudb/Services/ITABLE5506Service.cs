using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5506;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5506Service : IService<TABLE5506Dto, CreateTABLE5506Dto, UpdateTABLE5506Dto, int>
{
    Task<IEnumerable<TABLE5506Dto>> FindAsync(Expression<Func<TABLE5506, bool>> predicate);
}
