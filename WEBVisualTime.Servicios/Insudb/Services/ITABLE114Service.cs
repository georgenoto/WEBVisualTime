using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE114;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE114Service : IService<TABLE114Dto, CreateTABLE114Dto, UpdateTABLE114Dto, long>
{
    Task<IEnumerable<TABLE114Dto>> FindAsync(Expression<Func<TABLE114, bool>> predicate);
}
