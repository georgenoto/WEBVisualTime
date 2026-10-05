using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE79;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE79Service : IService<TABLE79Dto, CreateTABLE79Dto, UpdateTABLE79Dto, string>
{
    Task<IEnumerable<TABLE79Dto>> FindAsync(Expression<Func<TABLE79, bool>> predicate);
}
