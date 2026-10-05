using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_WIN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIENT_WINService : IService<CLIENT_WINDto, CreateCLIENT_WINDto, UpdateCLIENT_WINDto, string>
{
    Task<IEnumerable<CLIENT_WINDto>> FindAsync(Expression<Func<CLIENT_WIN, bool>> predicate);
}
