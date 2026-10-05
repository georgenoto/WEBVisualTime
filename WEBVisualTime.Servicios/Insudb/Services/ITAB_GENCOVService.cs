using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_GENCOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_GENCOVService : IService<TAB_GENCOVDto, CreateTAB_GENCOVDto, UpdateTAB_GENCOVDto, int>
{
    Task<IEnumerable<TAB_GENCOVDto>> FindAsync(Expression<Func<TAB_GENCOV, bool>> predicate);
}
