using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1007;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE1007Service : IService<TABLE1007Dto, CreateTABLE1007Dto, UpdateTABLE1007Dto, long>
{
    Task<IEnumerable<TABLE1007Dto>> FindAsync(Expression<Func<TABLE1007, bool>> predicate);
}
