using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_CONTACT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROV_CONTACTService : IService<TAB_PROV_CONTACTDto, CreateTAB_PROV_CONTACTDto, UpdateTAB_PROV_CONTACTDto, int>
{
    Task<IEnumerable<TAB_PROV_CONTACTDto>> FindAsync(Expression<Func<TAB_PROV_CONTACT, bool>> predicate);
}
