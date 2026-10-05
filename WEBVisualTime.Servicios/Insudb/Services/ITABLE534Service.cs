using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE534;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE534Service : IService<TABLE534Dto, CreateTABLE534Dto, UpdateTABLE534Dto, long>
{
    Task<IEnumerable<TABLE534Dto>> FindAsync(Expression<Func<TABLE534, bool>> predicate);
}
