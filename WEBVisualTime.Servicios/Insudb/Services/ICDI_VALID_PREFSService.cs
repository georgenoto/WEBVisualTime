using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_VALID_PREFS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_VALID_PREFSService : IService<CDI_VALID_PREFSDto, CreateCDI_VALID_PREFSDto, UpdateCDI_VALID_PREFSDto, string>
{
    Task<IEnumerable<CDI_VALID_PREFSDto>> FindAsync(Expression<Func<CDI_VALID_PREFS, bool>> predicate);
}
