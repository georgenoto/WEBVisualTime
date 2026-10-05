using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_VOUCHERService : IService<CLAIM_VOUCHERDto, CreateCLAIM_VOUCHERDto, UpdateCLAIM_VOUCHERDto, long>
{
    Task<IEnumerable<CLAIM_VOUCHERDto>> FindAsync(Expression<Func<CLAIM_VOUCHER, bool>> predicate);
}
