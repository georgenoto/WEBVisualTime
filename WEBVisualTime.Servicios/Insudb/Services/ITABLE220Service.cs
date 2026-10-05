using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE220;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE220Service : IService<TABLE220Dto, CreateTABLE220Dto, UpdateTABLE220Dto, int>
{
    Task<IEnumerable<TABLE220Dto>> FindAsync(Expression<Func<TABLE220, bool>> predicate);
}
