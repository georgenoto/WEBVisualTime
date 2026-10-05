using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LIFCOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_LIFCOVService : IService<TAB_LIFCOVDto, CreateTAB_LIFCOVDto, UpdateTAB_LIFCOVDto, int>
{
    Task<IEnumerable<TAB_LIFCOVDto>> FindAsync(Expression<Func<TAB_LIFCOV, bool>> predicate);
}
