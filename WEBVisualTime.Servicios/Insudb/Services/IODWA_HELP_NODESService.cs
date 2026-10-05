using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_NODES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IODWA_HELP_NODESService : IService<ODWA_HELP_NODESDto, CreateODWA_HELP_NODESDto, UpdateODWA_HELP_NODESDto, int>
{
    Task<IEnumerable<ODWA_HELP_NODESDto>> FindAsync(Expression<Func<ODWA_HELP_NODES, bool>> predicate);
}
