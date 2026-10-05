using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTER_MASS_SPONSOR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASTER_MASS_SPONSORService : IService<MASTER_MASS_SPONSORDto, CreateMASTER_MASS_SPONSORDto, UpdateMASTER_MASS_SPONSORDto, int>
{
    Task<IEnumerable<MASTER_MASS_SPONSORDto>> FindAsync(Expression<Func<MASTER_MASS_SPONSOR, bool>> predicate);
}
