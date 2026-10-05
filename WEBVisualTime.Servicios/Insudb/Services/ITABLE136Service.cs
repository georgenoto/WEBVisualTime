using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE136;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE136Service : IService<TABLE136Dto, CreateTABLE136Dto, UpdateTABLE136Dto, int>
{
    Task<IEnumerable<TABLE136Dto>> FindAsync(Expression<Func<TABLE136, bool>> predicate);
}
