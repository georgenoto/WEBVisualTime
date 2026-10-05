using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5564;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5564Service : IService<TABLE5564Dto, CreateTABLE5564Dto, UpdateTABLE5564Dto, int>
{
    Task<IEnumerable<TABLE5564Dto>> FindAsync(Expression<Func<TABLE5564, bool>> predicate);
}
