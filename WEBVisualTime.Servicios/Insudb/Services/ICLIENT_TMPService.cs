using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_TMP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIENT_TMPService : IService<CLIENT_TMPDto, CreateCLIENT_TMPDto, UpdateCLIENT_TMPDto, string>
{
    Task<IEnumerable<CLIENT_TMPDto>> FindAsync(Expression<Func<CLIENT_TMP, bool>> predicate);
}
