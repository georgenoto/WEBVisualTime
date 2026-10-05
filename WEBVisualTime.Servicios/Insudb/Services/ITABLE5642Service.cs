using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5642;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5642Service : IService<TABLE5642Dto, CreateTABLE5642Dto, UpdateTABLE5642Dto, int>
{
    Task<IEnumerable<TABLE5642Dto>> FindAsync(Expression<Func<TABLE5642, bool>> predicate);
}
