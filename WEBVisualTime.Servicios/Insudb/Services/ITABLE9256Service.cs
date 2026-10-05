using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9256;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9256Service : IService<TABLE9256Dto, CreateTABLE9256Dto, UpdateTABLE9256Dto, int>
{
    Task<IEnumerable<TABLE9256Dto>> FindAsync(Expression<Func<TABLE9256, bool>> predicate);
}
