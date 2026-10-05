using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9248;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9248Service : IService<TABLE9248Dto, CreateTABLE9248Dto, UpdateTABLE9248Dto, int>
{
    Task<IEnumerable<TABLE9248Dto>> FindAsync(Expression<Func<TABLE9248, bool>> predicate);
}
