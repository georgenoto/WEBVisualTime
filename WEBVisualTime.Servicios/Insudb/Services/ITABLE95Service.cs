using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE95;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE95Service : IService<TABLE95Dto, CreateTABLE95Dto, UpdateTABLE95Dto, int>
{
    Task<IEnumerable<TABLE95Dto>> FindAsync(Expression<Func<TABLE95, bool>> predicate);
}
