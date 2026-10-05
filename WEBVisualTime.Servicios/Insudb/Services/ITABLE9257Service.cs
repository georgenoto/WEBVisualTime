using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9257;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9257Service : IService<TABLE9257Dto, CreateTABLE9257Dto, UpdateTABLE9257Dto, int>
{
    Task<IEnumerable<TABLE9257Dto>> FindAsync(Expression<Func<TABLE9257, bool>> predicate);
}
