using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE37;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE37Service : IService<TABLE37Dto, CreateTABLE37Dto, UpdateTABLE37Dto, string>
{
    Task<IEnumerable<TABLE37Dto>> FindAsync(Expression<Func<TABLE37, bool>> predicate);
}
