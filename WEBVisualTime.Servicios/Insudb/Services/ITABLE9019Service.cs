using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9019;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9019Service : IService<TABLE9019Dto, CreateTABLE9019Dto, UpdateTABLE9019Dto, int>
{
    Task<IEnumerable<TABLE9019Dto>> FindAsync(Expression<Func<TABLE9019, bool>> predicate);
}
