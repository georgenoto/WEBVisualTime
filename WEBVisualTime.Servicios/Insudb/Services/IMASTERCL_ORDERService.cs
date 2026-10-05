using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_ORDER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASTERCL_ORDERService : IService<MASTERCL_ORDERDto, CreateMASTERCL_ORDERDto, UpdateMASTERCL_ORDERDto, long>
{
    Task<IEnumerable<MASTERCL_ORDERDto>> FindAsync(Expression<Func<MASTERCL_ORDER, bool>> predicate);
}
