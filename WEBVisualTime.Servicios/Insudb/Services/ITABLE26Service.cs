using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE26;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE26Service : IService<TABLE26Dto, CreateTABLE26Dto, UpdateTABLE26Dto, long>
{
    Task<IEnumerable<TABLE26Dto>> FindAsync(Expression<Func<TABLE26, bool>> predicate);
}
