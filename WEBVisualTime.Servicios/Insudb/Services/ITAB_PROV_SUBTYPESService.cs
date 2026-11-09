using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_SUBTYPES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROV_SUBTYPESService : IService<TAB_PROV_SUBTYPESDto, CreateTAB_PROV_SUBTYPESDto, UpdateTAB_PROV_SUBTYPESDto, string>
{
    Task<IEnumerable<TAB_PROV_SUBTYPESDto>> FindAsync(Expression<Func<TAB_PROV_SUBTYPES, bool>> predicate);
}
