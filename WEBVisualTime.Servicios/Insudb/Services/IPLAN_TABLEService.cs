using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PLAN_TABLE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPLAN_TABLEService : IService<PLAN_TABLEDto, CreatePLAN_TABLEDto, UpdatePLAN_TABLEDto, int>
{
    Task<IEnumerable<PLAN_TABLEDto>> FindAsync(Expression<Func<PLAN_TABLE, bool>> predicate);
}
