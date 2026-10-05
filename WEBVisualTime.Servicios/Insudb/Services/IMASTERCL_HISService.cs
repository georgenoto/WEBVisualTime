using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASTERCL_HISService : IService<MASTERCL_HISDto, CreateMASTERCL_HISDto, UpdateMASTERCL_HISDto, long>
{
    Task<IEnumerable<MASTERCL_HISDto>> FindAsync(Expression<Func<MASTERCL_HIS, bool>> predicate);
}
