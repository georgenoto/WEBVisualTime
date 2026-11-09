using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAX_FIXVAL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAX_FIXVALService : IService<TAX_FIXVALDto, CreateTAX_FIXVALDto, UpdateTAX_FIXVALDto, string>
{
    Task<IEnumerable<TAX_FIXVALDto>> FindAsync(Expression<Func<TAX_FIXVAL, bool>> predicate);
}
