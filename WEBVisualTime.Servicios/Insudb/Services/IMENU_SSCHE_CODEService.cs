using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MENU_SSCHE_CODE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMENU_SSCHE_CODEService : IService<MENU_SSCHE_CODEDto, CreateMENU_SSCHE_CODEDto, UpdateMENU_SSCHE_CODEDto, string>
{
    Task<IEnumerable<MENU_SSCHE_CODEDto>> FindAsync(Expression<Func<MENU_SSCHE_CODE, bool>> predicate);
}
