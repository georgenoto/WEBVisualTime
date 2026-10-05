using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9217;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9217Service : IService<TABLE9217Dto, CreateTABLE9217Dto, UpdateTABLE9217Dto, int>
{
    Task<IEnumerable<TABLE9217Dto>> FindAsync(Expression<Func<TABLE9217, bool>> predicate);
}
