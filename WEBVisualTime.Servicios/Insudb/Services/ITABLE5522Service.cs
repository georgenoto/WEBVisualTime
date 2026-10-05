using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5522;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5522Service : IService<TABLE5522Dto, CreateTABLE5522Dto, UpdateTABLE5522Dto, int>
{
    Task<IEnumerable<TABLE5522Dto>> FindAsync(Expression<Func<TABLE5522, bool>> predicate);
}
