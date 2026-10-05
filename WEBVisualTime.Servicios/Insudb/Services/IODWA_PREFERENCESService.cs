using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_PREFERENCES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IODWA_PREFERENCESService : IService<ODWA_PREFERENCESDto, CreateODWA_PREFERENCESDto, UpdateODWA_PREFERENCESDto, string>
{
    Task<IEnumerable<ODWA_PREFERENCESDto>> FindAsync(Expression<Func<ODWA_PREFERENCES, bool>> predicate);
}
