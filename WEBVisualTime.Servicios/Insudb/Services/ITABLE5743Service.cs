using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5743;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5743Service : IService<TABLE5743Dto, CreateTABLE5743Dto, UpdateTABLE5743Dto, int>
{
    Task<IEnumerable<TABLE5743Dto>> FindAsync(Expression<Func<TABLE5743, bool>> predicate);
}
