using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE72;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE72Service : IService<TABLE72Dto, CreateTABLE72Dto, UpdateTABLE72Dto, int>
{
    Task<IEnumerable<TABLE72Dto>> FindAsync(Expression<Func<TABLE72, bool>> predicate);
}
