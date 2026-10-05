using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TOAD_PLAN_TABLE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITOAD_PLAN_TABLEService : IService<TOAD_PLAN_TABLEDto, CreateTOAD_PLAN_TABLEDto, UpdateTOAD_PLAN_TABLEDto, int>
{
    Task<IEnumerable<TOAD_PLAN_TABLEDto>> FindAsync(Expression<Func<TOAD_PLAN_TABLE, bool>> predicate);
}
