using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9222;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9222Service : IService<TABLE9222Dto, CreateTABLE9222Dto, UpdateTABLE9222Dto, int>
{
    Task<IEnumerable<TABLE9222Dto>> FindAsync(Expression<Func<TABLE9222, bool>> predicate);
}
