using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_SETT_HISService : IService<CLAIM_SETT_HISDto, CreateCLAIM_SETT_HISDto, UpdateCLAIM_SETT_HISDto, long>
{
    Task<IEnumerable<CLAIM_SETT_HISDto>> FindAsync(Expression<Func<CLAIM_SETT_HIS, bool>> predicate);
}
