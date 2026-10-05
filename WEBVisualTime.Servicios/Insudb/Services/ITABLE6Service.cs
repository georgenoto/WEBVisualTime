using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6Service : IService<TABLE6Dto, CreateTABLE6Dto, UpdateTABLE6Dto, int>
{
    Task<IEnumerable<TABLE6Dto>> FindAsync(Expression<Func<TABLE6, bool>> predicate);
}
