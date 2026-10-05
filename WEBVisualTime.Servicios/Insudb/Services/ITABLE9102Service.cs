using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9102;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9102Service : IService<TABLE9102Dto, CreateTABLE9102Dto, UpdateTABLE9102Dto, int>
{
    Task<IEnumerable<TABLE9102Dto>> FindAsync(Expression<Func<TABLE9102, bool>> predicate);
}
