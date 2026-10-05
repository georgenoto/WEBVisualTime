using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CUR_ALLOW;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICUR_ALLOWService : IService<CUR_ALLOWDto, CreateCUR_ALLOWDto, UpdateCUR_ALLOWDto, int>
{
    Task<IEnumerable<CUR_ALLOWDto>> FindAsync(Expression<Func<CUR_ALLOW, bool>> predicate);
}
