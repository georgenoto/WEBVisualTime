using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_BENEF;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASTERCL_BENEFService : IService<MASTERCL_BENEFDto, CreateMASTERCL_BENEFDto, UpdateMASTERCL_BENEFDto, string>
{
    Task<IEnumerable<MASTERCL_BENEFDto>> FindAsync(Expression<Func<MASTERCL_BENEF, bool>> predicate);
}
