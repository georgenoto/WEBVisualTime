using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9261;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9261Service : IService<TABLE9261Dto, CreateTABLE9261Dto, UpdateTABLE9261Dto, int>
{
    Task<IEnumerable<TABLE9261Dto>> FindAsync(Expression<Func<TABLE9261, bool>> predicate);
}
