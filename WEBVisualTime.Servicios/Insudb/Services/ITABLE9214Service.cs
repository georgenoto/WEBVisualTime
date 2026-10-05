using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9214;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9214Service : IService<TABLE9214Dto, CreateTABLE9214Dto, UpdateTABLE9214Dto, int>
{
    Task<IEnumerable<TABLE9214Dto>> FindAsync(Expression<Func<TABLE9214, bool>> predicate);
}
