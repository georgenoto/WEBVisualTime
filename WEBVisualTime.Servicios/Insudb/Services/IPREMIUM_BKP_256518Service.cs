using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_BKP_256518;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPREMIUM_BKP_256518Service : IService<PREMIUM_BKP_256518Dto, CreatePREMIUM_BKP_256518Dto, UpdatePREMIUM_BKP_256518Dto, string>
{
    Task<IEnumerable<PREMIUM_BKP_256518Dto>> FindAsync(Expression<Func<PREMIUM_BKP_256518, bool>> predicate);
}
