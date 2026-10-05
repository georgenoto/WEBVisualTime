using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9021;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9021Service : IService<TABLE9021Dto, CreateTABLE9021Dto, UpdateTABLE9021Dto, int>
{
    Task<IEnumerable<TABLE9021Dto>> FindAsync(Expression<Func<TABLE9021, bool>> predicate);
}
