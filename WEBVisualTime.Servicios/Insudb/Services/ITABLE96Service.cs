using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE96;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE96Service : IService<TABLE96Dto, CreateTABLE96Dto, UpdateTABLE96Dto, long>
{
    Task<IEnumerable<TABLE96Dto>> FindAsync(Expression<Func<TABLE96, bool>> predicate);
}
