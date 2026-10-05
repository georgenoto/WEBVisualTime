using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9003;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9003Service : IService<TABLE9003Dto, CreateTABLE9003Dto, UpdateTABLE9003Dto, int>
{
    Task<IEnumerable<TABLE9003Dto>> FindAsync(Expression<Func<TABLE9003, bool>> predicate);
}
