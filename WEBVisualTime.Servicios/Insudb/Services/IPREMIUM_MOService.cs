using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_MO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPREMIUM_MOService : IService<PREMIUM_MODto, CreatePREMIUM_MODto, UpdatePREMIUM_MODto, long>
{
    Task<IEnumerable<PREMIUM_MODto>> FindAsync(Expression<Func<PREMIUM_MO, bool>> predicate);
}
