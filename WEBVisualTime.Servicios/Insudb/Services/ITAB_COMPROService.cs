using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COMPRO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_COMPROService : IService<TAB_COMPRODto, CreateTAB_COMPRODto, UpdateTAB_COMPRODto, int>
{
    Task<IEnumerable<TAB_COMPRODto>> FindAsync(Expression<Func<TAB_COMPRO, bool>> predicate);
}
