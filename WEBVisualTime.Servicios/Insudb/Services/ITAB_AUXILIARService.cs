using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AUXILIAR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_AUXILIARService : IService<TAB_AUXILIARDto, CreateTAB_AUXILIARDto, UpdateTAB_AUXILIARDto, string>
{
    Task<IEnumerable<TAB_AUXILIARDto>> FindAsync(Expression<Func<TAB_AUXILIAR, bool>> predicate);
}
