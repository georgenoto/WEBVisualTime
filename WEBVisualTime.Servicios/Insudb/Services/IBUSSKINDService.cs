using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BUSSKIND;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBUSSKINDService : IService<BUSSKINDDto, CreateBUSSKINDDto, UpdateBUSSKINDDto, int>
{
    Task<IEnumerable<BUSSKINDDto>> FindAsync(Expression<Func<BUSSKIND, bool>> predicate);
}
