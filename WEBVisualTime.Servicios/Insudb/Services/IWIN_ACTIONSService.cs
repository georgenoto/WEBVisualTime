using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_ACTIONS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IWIN_ACTIONSService : IService<WIN_ACTIONSDto, CreateWIN_ACTIONSDto, UpdateWIN_ACTIONSDto, string>
{
    Task<IEnumerable<WIN_ACTIONSDto>> FindAsync(Expression<Func<WIN_ACTIONS, bool>> predicate);
}
