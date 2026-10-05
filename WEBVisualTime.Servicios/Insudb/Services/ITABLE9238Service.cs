using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9238;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9238Service : IService<TABLE9238Dto, CreateTABLE9238Dto, UpdateTABLE9238Dto, int>
{
    Task<IEnumerable<TABLE9238Dto>> FindAsync(Expression<Func<TABLE9238, bool>> predicate);
}
