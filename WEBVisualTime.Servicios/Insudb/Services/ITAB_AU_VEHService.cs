using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AU_VEH;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_AU_VEHService : IService<TAB_AU_VEHDto, CreateTAB_AU_VEHDto, UpdateTAB_AU_VEHDto, string>
{
    Task<IEnumerable<TAB_AU_VEHDto>> FindAsync(Expression<Func<TAB_AU_VEH, bool>> predicate);
}
