using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5550;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5550Service : IService<TABLE5550Dto, CreateTABLE5550Dto, UpdateTABLE5550Dto, int>
{
    Task<IEnumerable<TABLE5550Dto>> FindAsync(Expression<Func<TABLE5550, bool>> predicate);
}
