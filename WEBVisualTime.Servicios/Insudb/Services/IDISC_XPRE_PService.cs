using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DISC_XPRE_P;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDISC_XPRE_PService : IService<DISC_XPRE_PDto, CreateDISC_XPRE_PDto, UpdateDISC_XPRE_PDto, string>
{
    Task<IEnumerable<DISC_XPRE_PDto>> FindAsync(Expression<Func<DISC_XPRE_P, bool>> predicate);
}
