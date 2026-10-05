using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MEDBENEFITS_CO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_MEDBENEFITS_COService : IService<TAB_MEDBENEFITS_CODto, CreateTAB_MEDBENEFITS_CODto, UpdateTAB_MEDBENEFITS_CODto, string>
{
    Task<IEnumerable<TAB_MEDBENEFITS_CODto>> FindAsync(Expression<Func<TAB_MEDBENEFITS_CO, bool>> predicate);
}
