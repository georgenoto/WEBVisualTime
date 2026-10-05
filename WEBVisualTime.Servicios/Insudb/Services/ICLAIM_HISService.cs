using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_HISService : IService<CLAIM_HISDto, CreateCLAIM_HISDto, UpdateCLAIM_HISDto, long>
{
    Task<IEnumerable<CLAIM_HISDto>> FindAsync(Expression<Func<CLAIM_HIS, bool>> predicate);
}
