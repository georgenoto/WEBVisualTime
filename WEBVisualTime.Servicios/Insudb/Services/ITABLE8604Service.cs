using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8604Service : IService<TABLE8604Dto, CreateTABLE8604Dto, UpdateTABLE8604Dto, string>
{
    Task<IEnumerable<TABLE8604Dto>> FindAsync(Expression<Func<TABLE8604, bool>> predicate);
}
