using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9030;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9030Service : IService<TABLE9030Dto, CreateTABLE9030Dto, UpdateTABLE9030Dto, int>
{
    Task<IEnumerable<TABLE9030Dto>> FindAsync(Expression<Func<TABLE9030, bool>> predicate);
}
