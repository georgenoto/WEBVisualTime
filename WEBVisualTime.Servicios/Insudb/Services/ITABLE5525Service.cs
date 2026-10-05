using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5525;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5525Service : IService<TABLE5525Dto, CreateTABLE5525Dto, UpdateTABLE5525Dto, int>
{
    Task<IEnumerable<TABLE5525Dto>> FindAsync(Expression<Func<TABLE5525, bool>> predicate);
}
