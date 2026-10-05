using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9056;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9056Service : IService<TABLE9056Dto, CreateTABLE9056Dto, UpdateTABLE9056Dto, int>
{
    Task<IEnumerable<TABLE9056Dto>> FindAsync(Expression<Func<TABLE9056, bool>> predicate);
}
