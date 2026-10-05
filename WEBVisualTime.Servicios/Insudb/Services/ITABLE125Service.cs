using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE125;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE125Service : IService<TABLE125Dto, CreateTABLE125Dto, UpdateTABLE125Dto, long>
{
    Task<IEnumerable<TABLE125Dto>> FindAsync(Expression<Func<TABLE125, bool>> predicate);
}
