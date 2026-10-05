using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9040;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9040Service : IService<TABLE9040Dto, CreateTABLE9040Dto, UpdateTABLE9040Dto, int>
{
    Task<IEnumerable<TABLE9040Dto>> FindAsync(Expression<Func<TABLE9040, bool>> predicate);
}
