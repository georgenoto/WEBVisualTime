using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE_COVER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILIFE_COVERService : IService<LIFE_COVERDto, CreateLIFE_COVERDto, UpdateLIFE_COVERDto, string>
{
    Task<IEnumerable<LIFE_COVERDto>> FindAsync(Expression<Func<LIFE_COVER, bool>> predicate);
}
