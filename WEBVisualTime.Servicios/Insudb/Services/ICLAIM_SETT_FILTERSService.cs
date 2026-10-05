using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_FILTERS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_SETT_FILTERSService : IService<CLAIM_SETT_FILTERSDto, CreateCLAIM_SETT_FILTERSDto, UpdateCLAIM_SETT_FILTERSDto, long>
{
    Task<IEnumerable<CLAIM_SETT_FILTERSDto>> FindAsync(Expression<Func<CLAIM_SETT_FILTERS, bool>> predicate);
}
