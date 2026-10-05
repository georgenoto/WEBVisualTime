using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IWINDOWSService : IService<WINDOWSDto, CreateWINDOWSDto, UpdateWINDOWSDto, string>
{
    Task<IEnumerable<WINDOWSDto>> FindAsync(Expression<Func<WINDOWS, bool>> predicate);
}
