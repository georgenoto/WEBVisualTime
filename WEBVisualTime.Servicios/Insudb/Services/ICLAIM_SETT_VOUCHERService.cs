using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_VOUCHER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_SETT_VOUCHERService : IService<CLAIM_SETT_VOUCHERDto, CreateCLAIM_SETT_VOUCHERDto, UpdateCLAIM_SETT_VOUCHERDto, string>
{
    Task<IEnumerable<CLAIM_SETT_VOUCHERDto>> FindAsync(Expression<Func<CLAIM_SETT_VOUCHER, bool>> predicate);
}
