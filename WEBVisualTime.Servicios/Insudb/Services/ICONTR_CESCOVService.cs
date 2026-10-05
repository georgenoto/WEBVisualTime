using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTR_CESCOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICONTR_CESCOVService : IService<CONTR_CESCOVDto, CreateCONTR_CESCOVDto, UpdateCONTR_CESCOVDto, int>
{
    Task<IEnumerable<CONTR_CESCOVDto>> FindAsync(Expression<Func<CONTR_CESCOV, bool>> predicate);
}
