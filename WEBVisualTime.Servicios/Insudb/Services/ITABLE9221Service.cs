using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9221;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9221Service : IService<TABLE9221Dto, CreateTABLE9221Dto, UpdateTABLE9221Dto, int>
{
    Task<IEnumerable<TABLE9221Dto>> FindAsync(Expression<Func<TABLE9221, bool>> predicate);
}
