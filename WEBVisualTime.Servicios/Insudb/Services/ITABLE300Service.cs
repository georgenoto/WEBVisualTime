using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE300;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE300Service : IService<TABLE300Dto, CreateTABLE300Dto, UpdateTABLE300Dto, long>
{
    Task<IEnumerable<TABLE300Dto>> FindAsync(Expression<Func<TABLE300, bool>> predicate);
}
