using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5503;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5503Service : IService<TABLE5503Dto, CreateTABLE5503Dto, UpdateTABLE5503Dto, long>
{
    Task<IEnumerable<TABLE5503Dto>> FindAsync(Expression<Func<TABLE5503, bool>> predicate);
}
