using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_DFLT_USER_PREFS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_DFLT_USER_PREFSService : IService<CDI_DFLT_USER_PREFSDto, CreateCDI_DFLT_USER_PREFSDto, UpdateCDI_DFLT_USER_PREFSDto, string>
{
    Task<IEnumerable<CDI_DFLT_USER_PREFSDto>> FindAsync(Expression<Func<CDI_DFLT_USER_PREFS, bool>> predicate);
}
