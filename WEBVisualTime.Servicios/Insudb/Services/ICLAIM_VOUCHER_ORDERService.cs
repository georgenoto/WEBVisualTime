using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER_ORDER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_VOUCHER_ORDERService : IService<CLAIM_VOUCHER_ORDERDto, CreateCLAIM_VOUCHER_ORDERDto, UpdateCLAIM_VOUCHER_ORDERDto, string>
{
    Task<IEnumerable<CLAIM_VOUCHER_ORDERDto>> FindAsync(Expression<Func<CLAIM_VOUCHER_ORDER, bool>> predicate);
}
