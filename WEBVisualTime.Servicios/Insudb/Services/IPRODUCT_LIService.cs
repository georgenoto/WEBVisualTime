using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODUCT_LI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPRODUCT_LIService : IService<PRODUCT_LIDto, CreatePRODUCT_LIDto, UpdatePRODUCT_LIDto, string>
{
    Task<IEnumerable<PRODUCT_LIDto>> FindAsync(Expression<Func<PRODUCT_LI, bool>> predicate);
}
