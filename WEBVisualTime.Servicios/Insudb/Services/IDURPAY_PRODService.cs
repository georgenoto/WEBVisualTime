using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DURPAY_PROD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDURPAY_PRODService : IService<DURPAY_PRODDto, CreateDURPAY_PRODDto, UpdateDURPAY_PRODDto, string>
{
    Task<IEnumerable<DURPAY_PRODDto>> FindAsync(Expression<Func<DURPAY_PROD, bool>> predicate);
}
