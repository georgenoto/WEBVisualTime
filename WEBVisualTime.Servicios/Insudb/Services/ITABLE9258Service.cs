using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9258;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9258Service : IService<TABLE9258Dto, CreateTABLE9258Dto, UpdateTABLE9258Dto, int>
{
    Task<IEnumerable<TABLE9258Dto>> FindAsync(Expression<Func<TABLE9258, bool>> predicate);
}
