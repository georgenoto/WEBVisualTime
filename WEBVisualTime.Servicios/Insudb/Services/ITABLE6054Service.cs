using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6054;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6054Service : IService<TABLE6054Dto, CreateTABLE6054Dto, UpdateTABLE6054Dto, int>
{
    Task<IEnumerable<TABLE6054Dto>> FindAsync(Expression<Func<TABLE6054, bool>> predicate);
}
