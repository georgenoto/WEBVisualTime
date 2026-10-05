using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5614;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5614Service : IService<TABLE5614Dto, CreateTABLE5614Dto, UpdateTABLE5614Dto, int>
{
    Task<IEnumerable<TABLE5614Dto>> FindAsync(Expression<Func<TABLE5614, bool>> predicate);
}
