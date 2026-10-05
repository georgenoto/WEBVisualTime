using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LOCAT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_LOCATService : IService<TAB_LOCATDto, CreateTAB_LOCATDto, UpdateTAB_LOCATDto, int>
{
    Task<IEnumerable<TAB_LOCATDto>> FindAsync(Expression<Func<TAB_LOCAT, bool>> predicate);
}
