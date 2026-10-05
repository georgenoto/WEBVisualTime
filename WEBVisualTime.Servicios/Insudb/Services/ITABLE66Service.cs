using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE66;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE66Service : IService<TABLE66Dto, CreateTABLE66Dto, UpdateTABLE66Dto, int>
{
    Task<IEnumerable<TABLE66Dto>> FindAsync(Expression<Func<TABLE66, bool>> predicate);
}
