using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9202;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9202Service : IService<TABLE9202Dto, CreateTABLE9202Dto, UpdateTABLE9202Dto, int>
{
    Task<IEnumerable<TABLE9202Dto>> FindAsync(Expression<Func<TABLE9202, bool>> predicate);
}
