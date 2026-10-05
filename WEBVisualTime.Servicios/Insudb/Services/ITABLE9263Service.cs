using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9263;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9263Service : IService<TABLE9263Dto, CreateTABLE9263Dto, UpdateTABLE9263Dto, int>
{
    Task<IEnumerable<TABLE9263Dto>> FindAsync(Expression<Func<TABLE9263, bool>> predicate);
}
