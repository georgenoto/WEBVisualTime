using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6002;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6002Service : IService<TABLE6002Dto, CreateTABLE6002Dto, UpdateTABLE6002Dto, int>
{
    Task<IEnumerable<TABLE6002Dto>> FindAsync(Expression<Func<TABLE6002, bool>> predicate);
}
