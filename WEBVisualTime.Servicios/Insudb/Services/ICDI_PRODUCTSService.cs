using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PRODUCTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_PRODUCTSService : IService<CDI_PRODUCTSDto, CreateCDI_PRODUCTSDto, UpdateCDI_PRODUCTSDto, string>
{
    Task<IEnumerable<CDI_PRODUCTSDto>> FindAsync(Expression<Func<CDI_PRODUCTS, bool>> predicate);
}
