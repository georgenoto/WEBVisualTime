using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE252;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE252Service : IService<TABLE252Dto, CreateTABLE252Dto, UpdateTABLE252Dto, long>
{
    Task<IEnumerable<TABLE252Dto>> FindAsync(Expression<Func<TABLE252, bool>> predicate);
}
