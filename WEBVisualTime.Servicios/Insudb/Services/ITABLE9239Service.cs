using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9239;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9239Service : IService<TABLE9239Dto, CreateTABLE9239Dto, UpdateTABLE9239Dto, int>
{
    Task<IEnumerable<TABLE9239Dto>> FindAsync(Expression<Func<TABLE9239, bool>> predicate);
}
