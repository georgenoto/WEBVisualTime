using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_REQ;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIENT_REQService : IService<CLIENT_REQDto, CreateCLIENT_REQDto, UpdateCLIENT_REQDto, int>
{
    Task<IEnumerable<CLIENT_REQDto>> FindAsync(Expression<Func<CLIENT_REQ, bool>> predicate);
}
