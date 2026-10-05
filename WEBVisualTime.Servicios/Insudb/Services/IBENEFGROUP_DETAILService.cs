using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFGROUP_DETAIL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBENEFGROUP_DETAILService : IService<BENEFGROUP_DETAILDto, CreateBENEFGROUP_DETAILDto, UpdateBENEFGROUP_DETAILDto, string>
{
    Task<IEnumerable<BENEFGROUP_DETAILDto>> FindAsync(Expression<Func<BENEFGROUP_DETAIL, bool>> predicate);
}
