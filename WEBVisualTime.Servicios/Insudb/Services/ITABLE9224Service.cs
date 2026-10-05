using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9224;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9224Service : IService<TABLE9224Dto, CreateTABLE9224Dto, UpdateTABLE9224Dto, int>
{
    Task<IEnumerable<TABLE9224Dto>> FindAsync(Expression<Func<TABLE9224, bool>> predicate);
}
