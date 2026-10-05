using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9007;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9007Service : IService<TABLE9007Dto, CreateTABLE9007Dto, UpdateTABLE9007Dto, int>
{
    Task<IEnumerable<TABLE9007Dto>> FindAsync(Expression<Func<TABLE9007, bool>> predicate);
}
