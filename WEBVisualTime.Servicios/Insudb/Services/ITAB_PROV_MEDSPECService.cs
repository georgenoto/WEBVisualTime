using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_MEDSPEC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROV_MEDSPECService : IService<TAB_PROV_MEDSPECDto, CreateTAB_PROV_MEDSPECDto, UpdateTAB_PROV_MEDSPECDto, int>
{
    Task<IEnumerable<TAB_PROV_MEDSPECDto>> FindAsync(Expression<Func<TAB_PROV_MEDSPEC, bool>> predicate);
}
