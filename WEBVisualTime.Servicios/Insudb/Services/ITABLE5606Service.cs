using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5606;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5606Service : IService<TABLE5606Dto, CreateTABLE5606Dto, UpdateTABLE5606Dto, int>
{
    Task<IEnumerable<TABLE5606Dto>> FindAsync(Expression<Func<TABLE5606, bool>> predicate);
}
