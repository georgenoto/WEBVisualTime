using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DISC_XPRE_G;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDISC_XPRE_GService : IService<DISC_XPRE_GDto, CreateDISC_XPRE_GDto, UpdateDISC_XPRE_GDto, string>
{
    Task<IEnumerable<DISC_XPRE_GDto>> FindAsync(Expression<Func<DISC_XPRE_G, bool>> predicate);
}
