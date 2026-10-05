using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6030;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6030Service : IService<TABLE6030Dto, CreateTABLE6030Dto, UpdateTABLE6030Dto, int>
{
    Task<IEnumerable<TABLE6030Dto>> FindAsync(Expression<Func<TABLE6030, bool>> predicate);
}
