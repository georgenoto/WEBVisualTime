using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5704;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5704Service : IService<TABLE5704Dto, CreateTABLE5704Dto, UpdateTABLE5704Dto, int>
{
    Task<IEnumerable<TABLE5704Dto>> FindAsync(Expression<Func<TABLE5704, bool>> predicate);
}
