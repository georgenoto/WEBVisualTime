using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE241;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE241Service : IService<TABLE241Dto, CreateTABLE241Dto, UpdateTABLE241Dto, int>
{
    Task<IEnumerable<TABLE241Dto>> FindAsync(Expression<Func<TABLE241, bool>> predicate);
}
