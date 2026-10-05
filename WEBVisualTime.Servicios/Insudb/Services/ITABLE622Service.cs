using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE622;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE622Service : IService<TABLE622Dto, CreateTABLE622Dto, UpdateTABLE622Dto, int>
{
    Task<IEnumerable<TABLE622Dto>> FindAsync(Expression<Func<TABLE622, bool>> predicate);
}
