using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE564;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE564Service : IService<TABLE564Dto, CreateTABLE564Dto, UpdateTABLE564Dto, int>
{
    Task<IEnumerable<TABLE564Dto>> FindAsync(Expression<Func<TABLE564, bool>> predicate);
}
