using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIENT_HISService : IService<CLIENT_HISDto, CreateCLIENT_HISDto, UpdateCLIENT_HISDto, string>
{
    Task<IEnumerable<CLIENT_HISDto>> FindAsync(Expression<Func<CLIENT_HIS, bool>> predicate);
}
