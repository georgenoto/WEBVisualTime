using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9237;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9237Service : IService<TABLE9237Dto, CreateTABLE9237Dto, UpdateTABLE9237Dto, int>
{
    Task<IEnumerable<TABLE9237Dto>> FindAsync(Expression<Func<TABLE9237, bool>> predicate);
}
