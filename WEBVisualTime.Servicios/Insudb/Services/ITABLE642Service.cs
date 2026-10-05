using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE642;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE642Service : IService<TABLE642Dto, CreateTABLE642Dto, UpdateTABLE642Dto, int>
{
    Task<IEnumerable<TABLE642Dto>> FindAsync(Expression<Func<TABLE642, bool>> predicate);
}
