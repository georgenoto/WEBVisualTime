using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5584;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5584Service : IService<TABLE5584Dto, CreateTABLE5584Dto, UpdateTABLE5584Dto, int>
{
    Task<IEnumerable<TABLE5584Dto>> FindAsync(Expression<Func<TABLE5584, bool>> predicate);
}
