using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TREHABILITATE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITREHABILITATEService : IService<TREHABILITATEDto, CreateTREHABILITATEDto, UpdateTREHABILITATEDto, int>
{
    Task<IEnumerable<TREHABILITATEDto>> FindAsync(Expression<Func<TREHABILITATE, bool>> predicate);
}
