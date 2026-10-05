using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TRACKING;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITRACKINGService : IService<TRACKINGDto, CreateTRACKINGDto, UpdateTRACKINGDto, int>
{
    Task<IEnumerable<TRACKINGDto>> FindAsync(Expression<Func<TRACKING, bool>> predicate);
}
