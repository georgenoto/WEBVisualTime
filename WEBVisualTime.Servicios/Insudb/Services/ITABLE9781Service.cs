using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9781;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9781Service : IService<TABLE9781Dto, CreateTABLE9781Dto, UpdateTABLE9781Dto, int>
{
    Task<IEnumerable<TABLE9781Dto>> FindAsync(Expression<Func<TABLE9781, bool>> predicate);
}
