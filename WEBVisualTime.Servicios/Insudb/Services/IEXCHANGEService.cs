using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.EXCHANGE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IEXCHANGEService : IService<EXCHANGEDto, CreateEXCHANGEDto, UpdateEXCHANGEDto, int>
{
    Task<IEnumerable<EXCHANGEDto>> FindAsync(Expression<Func<EXCHANGE, bool>> predicate);
}
