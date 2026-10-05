using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9026;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9026Service : IService<TABLE9026Dto, CreateTABLE9026Dto, UpdateTABLE9026Dto, int>
{
    Task<IEnumerable<TABLE9026Dto>> FindAsync(Expression<Func<TABLE9026, bool>> predicate);
}
