using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TOAD_PLAN_SQL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITOAD_PLAN_SQLService : IService<TOAD_PLAN_SQLDto, CreateTOAD_PLAN_SQLDto, UpdateTOAD_PLAN_SQLDto, string>
{
    Task<IEnumerable<TOAD_PLAN_SQLDto>> FindAsync(Expression<Func<TOAD_PLAN_SQL, bool>> predicate);
}
