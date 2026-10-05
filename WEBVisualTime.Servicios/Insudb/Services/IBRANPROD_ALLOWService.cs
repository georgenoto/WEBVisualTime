using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BRANPROD_ALLOW;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBRANPROD_ALLOWService : IService<BRANPROD_ALLOWDto, CreateBRANPROD_ALLOWDto, UpdateBRANPROD_ALLOWDto, long>
{
    Task<IEnumerable<BRANPROD_ALLOWDto>> FindAsync(Expression<Func<BRANPROD_ALLOW, bool>> predicate);
}
