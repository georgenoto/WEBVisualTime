using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5538;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5538Service : IService<TABLE5538Dto, CreateTABLE5538Dto, UpdateTABLE5538Dto, int>
{
    Task<IEnumerable<TABLE5538Dto>> FindAsync(Expression<Func<TABLE5538, bool>> predicate);
}
