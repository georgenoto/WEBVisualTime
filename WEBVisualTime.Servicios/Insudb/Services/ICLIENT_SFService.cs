using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_SF;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIENT_SFService : IService<CLIENT_SFDto, CreateCLIENT_SFDto, UpdateCLIENT_SFDto, string>
{
    Task<IEnumerable<CLIENT_SFDto>> FindAsync(Expression<Func<CLIENT_SF, bool>> predicate);
}
