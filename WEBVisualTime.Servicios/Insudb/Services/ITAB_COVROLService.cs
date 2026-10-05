using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COVROL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_COVROLService : IService<TAB_COVROLDto, CreateTAB_COVROLDto, UpdateTAB_COVROLDto, int>
{
    Task<IEnumerable<TAB_COVROLDto>> FindAsync(Expression<Func<TAB_COVROL, bool>> predicate);
}
