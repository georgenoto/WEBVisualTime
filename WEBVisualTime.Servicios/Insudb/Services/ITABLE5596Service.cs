using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5596;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5596Service : IService<TABLE5596Dto, CreateTABLE5596Dto, UpdateTABLE5596Dto, int>
{
    Task<IEnumerable<TABLE5596Dto>> FindAsync(Expression<Func<TABLE5596, bool>> predicate);
}
