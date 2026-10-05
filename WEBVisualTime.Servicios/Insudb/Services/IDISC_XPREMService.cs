using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DISC_XPREM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDISC_XPREMService : IService<DISC_XPREMDto, CreateDISC_XPREMDto, UpdateDISC_XPREMDto, string>
{
    Task<IEnumerable<DISC_XPREMDto>> FindAsync(Expression<Func<DISC_XPREM, bool>> predicate);
}
