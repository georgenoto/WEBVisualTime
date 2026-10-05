using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_DFLT_USER_PREF_USAGES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_DFLT_USER_PREF_USAGESService : IService<CDI_DFLT_USER_PREF_USAGESDto, CreateCDI_DFLT_USER_PREF_USAGESDto, UpdateCDI_DFLT_USER_PREF_USAGESDto, string>
{
    Task<IEnumerable<CDI_DFLT_USER_PREF_USAGESDto>> FindAsync(Expression<Func<CDI_DFLT_USER_PREF_USAGES, bool>> predicate);
}
