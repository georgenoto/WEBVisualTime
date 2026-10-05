using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TRACE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITRACEService : IService<TRACEDto, CreateTRACEDto, UpdateTRACEDto, long>
{
    Task<IEnumerable<TRACEDto>> FindAsync(Expression<Func<TRACE, bool>> predicate);
}
