using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE903;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE903Service : IService<TABLE903Dto, CreateTABLE903Dto, UpdateTABLE903Dto, int>
{
    Task<IEnumerable<TABLE903Dto>> FindAsync(Expression<Func<TABLE903, bool>> predicate);
}
