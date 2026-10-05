using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE273;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE273Service : IService<TABLE273Dto, CreateTABLE273Dto, UpdateTABLE273Dto, int>
{
    Task<IEnumerable<TABLE273Dto>> FindAsync(Expression<Func<TABLE273, bool>> predicate);
}
