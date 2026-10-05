using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9050;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9050Service : IService<TABLE9050Dto, CreateTABLE9050Dto, UpdateTABLE9050Dto, int>
{
    Task<IEnumerable<TABLE9050Dto>> FindAsync(Expression<Func<TABLE9050, bool>> predicate);
}
