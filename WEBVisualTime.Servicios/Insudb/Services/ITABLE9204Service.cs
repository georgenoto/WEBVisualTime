using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9204;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9204Service : IService<TABLE9204Dto, CreateTABLE9204Dto, UpdateTABLE9204Dto, int>
{
    Task<IEnumerable<TABLE9204Dto>> FindAsync(Expression<Func<TABLE9204, bool>> predicate);
}
