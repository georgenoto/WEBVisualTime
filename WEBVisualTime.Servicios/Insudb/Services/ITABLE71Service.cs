using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE71Service : IService<TABLE71Dto, CreateTABLE71Dto, UpdateTABLE71Dto, int>
{
    Task<IEnumerable<TABLE71Dto>> FindAsync(Expression<Func<TABLE71, bool>> predicate);
}
