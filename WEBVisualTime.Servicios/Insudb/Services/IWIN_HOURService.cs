using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_HOUR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IWIN_HOURService : IService<WIN_HOURDto, CreateWIN_HOURDto, UpdateWIN_HOURDto, string>
{
    Task<IEnumerable<WIN_HOURDto>> FindAsync(Expression<Func<WIN_HOUR, bool>> predicate);
}
