using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5556Service : IService<TABLE5556Dto, CreateTABLE5556Dto, UpdateTABLE5556Dto, int>
{
    Task<IEnumerable<TABLE5556Dto>> FindAsync(Expression<Func<TABLE5556, bool>> predicate);
}
