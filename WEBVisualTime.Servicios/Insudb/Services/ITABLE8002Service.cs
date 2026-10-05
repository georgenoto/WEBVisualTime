using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8002;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8002Service : IService<TABLE8002Dto, CreateTABLE8002Dto, UpdateTABLE8002Dto, int>
{
    Task<IEnumerable<TABLE8002Dto>> FindAsync(Expression<Func<TABLE8002, bool>> predicate);
}
