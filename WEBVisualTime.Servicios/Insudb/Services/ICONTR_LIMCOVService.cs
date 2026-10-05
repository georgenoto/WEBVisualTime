using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTR_LIMCOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICONTR_LIMCOVService : IService<CONTR_LIMCOVDto, CreateCONTR_LIMCOVDto, UpdateCONTR_LIMCOVDto, int>
{
    Task<IEnumerable<CONTR_LIMCOVDto>> FindAsync(Expression<Func<CONTR_LIMCOV, bool>> predicate);
}
