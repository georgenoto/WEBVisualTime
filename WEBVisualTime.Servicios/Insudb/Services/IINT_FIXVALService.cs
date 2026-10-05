using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INT_FIXVAL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IINT_FIXVALService : IService<INT_FIXVALDto, CreateINT_FIXVALDto, UpdateINT_FIXVALDto, int>
{
    Task<IEnumerable<INT_FIXVALDto>> FindAsync(Expression<Func<INT_FIXVAL, bool>> predicate);
}
