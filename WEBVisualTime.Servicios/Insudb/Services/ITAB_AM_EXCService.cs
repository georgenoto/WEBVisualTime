using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_EXC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_AM_EXCService : IService<TAB_AM_EXCDto, CreateTAB_AM_EXCDto, UpdateTAB_AM_EXCDto, string>
{
    Task<IEnumerable<TAB_AM_EXCDto>> FindAsync(Expression<Func<TAB_AM_EXC, bool>> predicate);
}
