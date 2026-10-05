using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NUMERATOR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface INUMERATORService : IService<NUMERATORDto, CreateNUMERATORDto, UpdateNUMERATORDto, int>
{
    Task<IEnumerable<NUMERATORDto>> FindAsync(Expression<Func<NUMERATOR, bool>> predicate);
}
