using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5526;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5526Service : IService<TABLE5526Dto, CreateTABLE5526Dto, UpdateTABLE5526Dto, int>
{
    Task<IEnumerable<TABLE5526Dto>> FindAsync(Expression<Func<TABLE5526, bool>> predicate);
}
