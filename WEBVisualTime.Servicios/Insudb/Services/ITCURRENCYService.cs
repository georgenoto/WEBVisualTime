using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCURRENCY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITCURRENCYService : IService<TCURRENCYDto, CreateTCURRENCYDto, UpdateTCURRENCYDto, string>
{
    Task<IEnumerable<TCURRENCYDto>> FindAsync(Expression<Func<TCURRENCY, bool>> predicate);
}
