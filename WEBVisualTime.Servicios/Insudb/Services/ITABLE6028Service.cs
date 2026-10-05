using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6028;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6028Service : IService<TABLE6028Dto, CreateTABLE6028Dto, UpdateTABLE6028Dto, int>
{
    Task<IEnumerable<TABLE6028Dto>> FindAsync(Expression<Func<TABLE6028, bool>> predicate);
}
