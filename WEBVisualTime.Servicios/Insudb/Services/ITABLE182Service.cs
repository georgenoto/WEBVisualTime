using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE182;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE182Service : IService<TABLE182Dto, CreateTABLE182Dto, UpdateTABLE182Dto, string>
{
    Task<IEnumerable<TABLE182Dto>> FindAsync(Expression<Func<TABLE182, bool>> predicate);
}
