using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9029;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9029Service : IService<TABLE9029Dto, CreateTABLE9029Dto, UpdateTABLE9029Dto, int>
{
    Task<IEnumerable<TABLE9029Dto>> FindAsync(Expression<Func<TABLE9029, bool>> predicate);
}
