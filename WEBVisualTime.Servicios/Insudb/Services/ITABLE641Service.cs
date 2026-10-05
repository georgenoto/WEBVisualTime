using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE641;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE641Service : IService<TABLE641Dto, CreateTABLE641Dto, UpdateTABLE641Dto, long>
{
    Task<IEnumerable<TABLE641Dto>> FindAsync(Expression<Func<TABLE641, bool>> predicate);
}
