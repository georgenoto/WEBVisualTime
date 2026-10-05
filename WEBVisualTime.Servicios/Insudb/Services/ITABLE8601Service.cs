using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8601;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8601Service : IService<TABLE8601Dto, CreateTABLE8601Dto, UpdateTABLE8601Dto, string>
{
    Task<IEnumerable<TABLE8601Dto>> FindAsync(Expression<Func<TABLE8601, bool>> predicate);
}
