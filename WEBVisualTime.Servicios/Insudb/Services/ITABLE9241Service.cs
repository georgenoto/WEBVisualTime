using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9241;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9241Service : IService<TABLE9241Dto, CreateTABLE9241Dto, UpdateTABLE9241Dto, int>
{
    Task<IEnumerable<TABLE9241Dto>> FindAsync(Expression<Func<TABLE9241, bool>> predicate);
}
