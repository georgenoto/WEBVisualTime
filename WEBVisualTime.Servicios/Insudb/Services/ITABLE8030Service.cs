using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8030;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8030Service : IService<TABLE8030Dto, CreateTABLE8030Dto, UpdateTABLE8030Dto, int>
{
    Task<IEnumerable<TABLE8030Dto>> FindAsync(Expression<Func<TABLE8030, bool>> predicate);
}
