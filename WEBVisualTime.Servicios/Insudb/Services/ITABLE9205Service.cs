using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9205;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9205Service : IService<TABLE9205Dto, CreateTABLE9205Dto, UpdateTABLE9205Dto, int>
{
    Task<IEnumerable<TABLE9205Dto>> FindAsync(Expression<Func<TABLE9205, bool>> predicate);
}
