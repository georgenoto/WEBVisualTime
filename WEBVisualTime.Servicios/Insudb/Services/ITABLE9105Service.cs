using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9105;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9105Service : IService<TABLE9105Dto, CreateTABLE9105Dto, UpdateTABLE9105Dto, int>
{
    Task<IEnumerable<TABLE9105Dto>> FindAsync(Expression<Func<TABLE9105, bool>> predicate);
}
