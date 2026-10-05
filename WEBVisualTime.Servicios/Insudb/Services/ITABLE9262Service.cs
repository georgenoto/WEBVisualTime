using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9262;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9262Service : IService<TABLE9262Dto, CreateTABLE9262Dto, UpdateTABLE9262Dto, int>
{
    Task<IEnumerable<TABLE9262Dto>> FindAsync(Expression<Func<TABLE9262, bool>> predicate);
}
