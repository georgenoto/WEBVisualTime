using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE563;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE563Service : IService<TABLE563Dto, CreateTABLE563Dto, UpdateTABLE563Dto, long>
{
    Task<IEnumerable<TABLE563Dto>> FindAsync(Expression<Func<TABLE563, bool>> predicate);
}
