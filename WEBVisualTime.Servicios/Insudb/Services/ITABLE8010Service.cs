using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8010;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8010Service : IService<TABLE8010Dto, CreateTABLE8010Dto, UpdateTABLE8010Dto, long>
{
    Task<IEnumerable<TABLE8010Dto>> FindAsync(Expression<Func<TABLE8010, bool>> predicate);
}
