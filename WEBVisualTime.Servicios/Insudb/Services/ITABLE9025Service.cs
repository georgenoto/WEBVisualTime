using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9025;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9025Service : IService<TABLE9025Dto, CreateTABLE9025Dto, UpdateTABLE9025Dto, int>
{
    Task<IEnumerable<TABLE9025Dto>> FindAsync(Expression<Func<TABLE9025, bool>> predicate);
}
