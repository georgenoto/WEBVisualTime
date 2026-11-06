using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_ITEMS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IODWA_HELP_ITEMSService : IService<ODWA_HELP_ITEMSDto, CreateODWA_HELP_ITEMSDto, UpdateODWA_HELP_ITEMSDto, long>
{
    Task<IEnumerable<ODWA_HELP_ITEMSDto>> FindAsync(Expression<Func<ODWA_HELP_ITEMS, bool>> predicate);
}
