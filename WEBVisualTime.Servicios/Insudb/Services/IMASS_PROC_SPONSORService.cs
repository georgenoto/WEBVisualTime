using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASS_PROC_SPONSOR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASS_PROC_SPONSORService : IService<MASS_PROC_SPONSORDto, CreateMASS_PROC_SPONSORDto, UpdateMASS_PROC_SPONSORDto, string>
{
    Task<IEnumerable<MASS_PROC_SPONSORDto>> FindAsync(Expression<Func<MASS_PROC_SPONSOR, bool>> predicate);
}
