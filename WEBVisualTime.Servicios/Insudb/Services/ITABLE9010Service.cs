using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9010;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9010Service : IService<TABLE9010Dto, CreateTABLE9010Dto, UpdateTABLE9010Dto, int>
{
    Task<IEnumerable<TABLE9010Dto>> FindAsync(Expression<Func<TABLE9010, bool>> predicate);
}
