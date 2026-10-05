using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE304;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE304Service : IService<TABLE304Dto, CreateTABLE304Dto, UpdateTABLE304Dto, long>
{
    Task<IEnumerable<TABLE304Dto>> FindAsync(Expression<Func<TABLE304, bool>> predicate);
}
