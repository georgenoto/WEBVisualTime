using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.STIPEND_POL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISTIPEND_POLService : IService<STIPEND_POLDto, CreateSTIPEND_POLDto, UpdateSTIPEND_POLDto, string>
{
    Task<IEnumerable<STIPEND_POLDto>> FindAsync(Expression<Func<STIPEND_POL, bool>> predicate);
}
