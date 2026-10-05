using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8090;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8090Service : IService<TABLE8090Dto, CreateTABLE8090Dto, UpdateTABLE8090Dto, int>
{
    Task<IEnumerable<TABLE8090Dto>> FindAsync(Expression<Func<TABLE8090, bool>> predicate);
}
