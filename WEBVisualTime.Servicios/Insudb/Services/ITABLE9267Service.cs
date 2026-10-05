using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9267;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9267Service : IService<TABLE9267Dto, CreateTABLE9267Dto, UpdateTABLE9267Dto, int>
{
    Task<IEnumerable<TABLE9267Dto>> FindAsync(Expression<Func<TABLE9267, bool>> predicate);
}
