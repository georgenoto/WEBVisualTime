using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFICIAR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBENEFICIARService : IService<BENEFICIARDto, CreateBENEFICIARDto, UpdateBENEFICIARDto, string>
{
    Task<IEnumerable<BENEFICIARDto>> FindAsync(Expression<Func<BENEFICIAR, bool>> predicate);
}
