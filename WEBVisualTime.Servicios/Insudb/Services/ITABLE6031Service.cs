using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6031;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6031Service : IService<TABLE6031Dto, CreateTABLE6031Dto, UpdateTABLE6031Dto, int>
{
    Task<IEnumerable<TABLE6031Dto>> FindAsync(Expression<Func<TABLE6031, bool>> predicate);
}
