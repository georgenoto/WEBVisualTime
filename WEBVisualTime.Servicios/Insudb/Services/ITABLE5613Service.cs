using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5613;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5613Service : IService<TABLE5613Dto, CreateTABLE5613Dto, UpdateTABLE5613Dto, int>
{
    Task<IEnumerable<TABLE5613Dto>> FindAsync(Expression<Func<TABLE5613, bool>> predicate);
}
