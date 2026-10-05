using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE193;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE193Service : IService<TABLE193Dto, CreateTABLE193Dto, UpdateTABLE193Dto, string>
{
    Task<IEnumerable<TABLE193Dto>> FindAsync(Expression<Func<TABLE193, bool>> predicate);
}
