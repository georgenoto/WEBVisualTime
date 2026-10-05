using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE201;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE201Service : IService<TABLE201Dto, CreateTABLE201Dto, UpdateTABLE201Dto, int>
{
    Task<IEnumerable<TABLE201Dto>> FindAsync(Expression<Func<TABLE201, bool>> predicate);
}
