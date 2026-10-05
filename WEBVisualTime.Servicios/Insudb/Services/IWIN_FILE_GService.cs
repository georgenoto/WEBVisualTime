using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_FILE_G;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IWIN_FILE_GService : IService<WIN_FILE_GDto, CreateWIN_FILE_GDto, UpdateWIN_FILE_GDto, string>
{
    Task<IEnumerable<WIN_FILE_GDto>> FindAsync(Expression<Func<WIN_FILE_G, bool>> predicate);
}
