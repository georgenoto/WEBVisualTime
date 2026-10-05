using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9015;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9015Service : IService<TABLE9015Dto, CreateTABLE9015Dto, UpdateTABLE9015Dto, int>
{
    Task<IEnumerable<TABLE9015Dto>> FindAsync(Expression<Func<TABLE9015, bool>> predicate);
}
