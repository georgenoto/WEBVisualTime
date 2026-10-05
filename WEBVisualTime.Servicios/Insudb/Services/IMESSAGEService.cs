using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MESSAGE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMESSAGEService : IService<MESSAGEDto, CreateMESSAGEDto, UpdateMESSAGEDto, long>
{
    Task<IEnumerable<MESSAGEDto>> FindAsync(Expression<Func<MESSAGE, bool>> predicate);
}
