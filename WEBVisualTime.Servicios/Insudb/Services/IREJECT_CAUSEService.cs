using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REJECT_CAUSE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREJECT_CAUSEService : IService<REJECT_CAUSEDto, CreateREJECT_CAUSEDto, UpdateREJECT_CAUSEDto, int>
{
    Task<IEnumerable<REJECT_CAUSEDto>> FindAsync(Expression<Func<REJECT_CAUSE, bool>> predicate);
}
