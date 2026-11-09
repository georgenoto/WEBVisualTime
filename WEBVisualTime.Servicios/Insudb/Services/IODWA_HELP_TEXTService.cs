using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_TEXT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IODWA_HELP_TEXTService : IService<ODWA_HELP_TEXTDto, CreateODWA_HELP_TEXTDto, UpdateODWA_HELP_TEXTDto, string>
{
    Task<IEnumerable<ODWA_HELP_TEXTDto>> FindAsync(Expression<Func<ODWA_HELP_TEXT, bool>> predicate);
}
