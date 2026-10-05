using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE20;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE20Service : IService<TABLE20Dto, CreateTABLE20Dto, UpdateTABLE20Dto, long>
{
    Task<IEnumerable<TABLE20Dto>> FindAsync(Expression<Func<TABLE20, bool>> predicate);
}
