using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9219;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9219Service : IService<TABLE9219Dto, CreateTABLE9219Dto, UpdateTABLE9219Dto, int>
{
    Task<IEnumerable<TABLE9219Dto>> FindAsync(Expression<Func<TABLE9219, bool>> predicate);
}
