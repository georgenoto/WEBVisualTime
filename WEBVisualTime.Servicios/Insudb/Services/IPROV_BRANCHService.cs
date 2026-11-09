using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROV_BRANCH;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPROV_BRANCHService : IService<PROV_BRANCHDto, CreatePROV_BRANCHDto, UpdatePROV_BRANCHDto, string>
{
    Task<IEnumerable<PROV_BRANCHDto>> FindAsync(Expression<Func<PROV_BRANCH, bool>> predicate);
}
