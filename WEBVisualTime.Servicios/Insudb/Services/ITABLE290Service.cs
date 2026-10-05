using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE290;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE290Service : IService<TABLE290Dto, CreateTABLE290Dto, UpdateTABLE290Dto, long>
{
    Task<IEnumerable<TABLE290Dto>> FindAsync(Expression<Func<TABLE290, bool>> predicate);
}
