using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE259;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE259Service : IService<TABLE259Dto, CreateTABLE259Dto, UpdateTABLE259Dto, long>
{
    Task<IEnumerable<TABLE259Dto>> FindAsync(Expression<Func<TABLE259, bool>> predicate);
}
