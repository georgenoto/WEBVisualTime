using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6001;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6001Service : IService<TABLE6001Dto, CreateTABLE6001Dto, UpdateTABLE6001Dto, int>
{
    Task<IEnumerable<TABLE6001Dto>> FindAsync(Expression<Func<TABLE6001, bool>> predicate);
}
