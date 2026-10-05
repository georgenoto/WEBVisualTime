using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5632;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5632Service : IService<TABLE5632Dto, CreateTABLE5632Dto, UpdateTABLE5632Dto, string>
{
    Task<IEnumerable<TABLE5632Dto>> FindAsync(Expression<Func<TABLE5632, bool>> predicate);
}
