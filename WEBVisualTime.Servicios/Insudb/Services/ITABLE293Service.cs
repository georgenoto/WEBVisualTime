using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE293;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE293Service : IService<TABLE293Dto, CreateTABLE293Dto, UpdateTABLE293Dto, int>
{
    Task<IEnumerable<TABLE293Dto>> FindAsync(Expression<Func<TABLE293, bool>> predicate);
}
