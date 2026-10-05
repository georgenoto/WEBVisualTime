using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_NAV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_NAVService : IService<CDI_NAVDto, CreateCDI_NAVDto, UpdateCDI_NAVDto, string>
{
    Task<IEnumerable<CDI_NAVDto>> FindAsync(Expression<Func<CDI_NAV, bool>> predicate);
}
