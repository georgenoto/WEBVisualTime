using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6003;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6003Service : IService<TABLE6003Dto, CreateTABLE6003Dto, UpdateTABLE6003Dto, int>
{
    Task<IEnumerable<TABLE6003Dto>> FindAsync(Expression<Func<TABLE6003, bool>> predicate);
}
