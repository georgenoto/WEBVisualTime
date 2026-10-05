using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9234;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9234Service : IService<TABLE9234Dto, CreateTABLE9234Dto, UpdateTABLE9234Dto, int>
{
    Task<IEnumerable<TABLE9234Dto>> FindAsync(Expression<Func<TABLE9234, bool>> predicate);
}
