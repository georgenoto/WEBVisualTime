using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_TYPE_MATCH;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_TYPE_MATCHService : IService<CDI_TYPE_MATCHDto, CreateCDI_TYPE_MATCHDto, UpdateCDI_TYPE_MATCHDto, string>
{
    Task<IEnumerable<CDI_TYPE_MATCHDto>> FindAsync(Expression<Func<CDI_TYPE_MATCH, bool>> predicate);
}
