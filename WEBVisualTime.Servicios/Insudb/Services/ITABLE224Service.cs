using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE224;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE224Service : IService<TABLE224Dto, CreateTABLE224Dto, UpdateTABLE224Dto, long>
{
    Task<IEnumerable<TABLE224Dto>> FindAsync(Expression<Func<TABLE224, bool>> predicate);
}
