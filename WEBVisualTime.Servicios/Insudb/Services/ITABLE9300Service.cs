using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9300;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9300Service : IService<TABLE9300Dto, CreateTABLE9300Dto, UpdateTABLE9300Dto, int>
{
    Task<IEnumerable<TABLE9300Dto>> FindAsync(Expression<Func<TABLE9300, bool>> predicate);
}
