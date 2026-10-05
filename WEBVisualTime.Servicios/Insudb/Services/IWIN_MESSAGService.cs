using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_MESSAG;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IWIN_MESSAGService : IService<WIN_MESSAGDto, CreateWIN_MESSAGDto, UpdateWIN_MESSAGDto, string>
{
    Task<IEnumerable<WIN_MESSAGDto>> FindAsync(Expression<Func<WIN_MESSAG, bool>> predicate);
}
