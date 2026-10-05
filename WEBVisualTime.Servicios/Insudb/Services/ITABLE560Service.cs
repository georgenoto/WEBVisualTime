using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE560;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE560Service : IService<TABLE560Dto, CreateTABLE560Dto, UpdateTABLE560Dto, int>
{
    Task<IEnumerable<TABLE560Dto>> FindAsync(Expression<Func<TABLE560, bool>> predicate);
}
