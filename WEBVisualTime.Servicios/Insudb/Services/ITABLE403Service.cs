using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE403;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE403Service : IService<TABLE403Dto, CreateTABLE403Dto, UpdateTABLE403Dto, long>
{
    Task<IEnumerable<TABLE403Dto>> FindAsync(Expression<Func<TABLE403, bool>> predicate);
}
