using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROV_TABLIFCOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPROV_TABLIFCOVService : IService<PROV_TABLIFCOVDto, CreatePROV_TABLIFCOVDto, UpdatePROV_TABLIFCOVDto, string>
{
    Task<IEnumerable<PROV_TABLIFCOVDto>> FindAsync(Expression<Func<PROV_TABLIFCOV, bool>> predicate);
}
