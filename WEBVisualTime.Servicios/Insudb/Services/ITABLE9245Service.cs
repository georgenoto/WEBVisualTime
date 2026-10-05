using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9245;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9245Service : IService<TABLE9245Dto, CreateTABLE9245Dto, UpdateTABLE9245Dto, int>
{
    Task<IEnumerable<TABLE9245Dto>> FindAsync(Expression<Func<TABLE9245, bool>> predicate);
}
