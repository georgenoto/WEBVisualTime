using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCOVER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITCOVERService : IService<TCOVERDto, CreateTCOVERDto, UpdateTCOVERDto, string>
{
    Task<IEnumerable<TCOVERDto>> FindAsync(Expression<Func<TCOVER, bool>> predicate);
}
