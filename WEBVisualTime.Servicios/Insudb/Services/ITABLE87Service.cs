using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE87;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE87Service : IService<TABLE87Dto, CreateTABLE87Dto, UpdateTABLE87Dto, int>
{
    Task<IEnumerable<TABLE87Dto>> FindAsync(Expression<Func<TABLE87, bool>> predicate);
}
