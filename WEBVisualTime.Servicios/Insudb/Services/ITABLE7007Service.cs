using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7007;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7007Service : IService<TABLE7007Dto, CreateTABLE7007Dto, UpdateTABLE7007Dto, long>
{
    Task<IEnumerable<TABLE7007Dto>> FindAsync(Expression<Func<TABLE7007, bool>> predicate);
}
