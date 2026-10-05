using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MATRIX_RH;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_MATRIX_RHService : IService<TAB_MATRIX_RHDto, CreateTAB_MATRIX_RHDto, UpdateTAB_MATRIX_RHDto, int>
{
    Task<IEnumerable<TAB_MATRIX_RHDto>> FindAsync(Expression<Func<TAB_MATRIX_RH, bool>> predicate);
}
