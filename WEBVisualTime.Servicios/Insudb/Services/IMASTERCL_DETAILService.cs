using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_DETAIL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASTERCL_DETAILService : IService<MASTERCL_DETAILDto, CreateMASTERCL_DETAILDto, UpdateMASTERCL_DETAILDto, string>
{
    Task<IEnumerable<MASTERCL_DETAILDto>> FindAsync(Expression<Func<MASTERCL_DETAIL, bool>> predicate);
}
