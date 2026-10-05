using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_SYS_EXE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_SYS_EXEService : IService<TAB_SYS_EXEDto, CreateTAB_SYS_EXEDto, UpdateTAB_SYS_EXEDto, int>
{
    Task<IEnumerable<TAB_SYS_EXEDto>> FindAsync(Expression<Func<TAB_SYS_EXE, bool>> predicate);
}
