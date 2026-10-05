using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE183;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE183Service : IService<TABLE183Dto, CreateTABLE183Dto, UpdateTABLE183Dto, int>
{
    Task<IEnumerable<TABLE183Dto>> FindAsync(Expression<Func<TABLE183, bool>> predicate);
}
