using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE334;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE334Service : IService<TABLE334Dto, CreateTABLE334Dto, UpdateTABLE334Dto, int>
{
    Task<IEnumerable<TABLE334Dto>> FindAsync(Expression<Func<TABLE334, bool>> predicate);
}
