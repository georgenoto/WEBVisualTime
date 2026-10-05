using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6070;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6070Service : IService<TABLE6070Dto, CreateTABLE6070Dto, UpdateTABLE6070Dto, string>
{
    Task<IEnumerable<TABLE6070Dto>> FindAsync(Expression<Func<TABLE6070, bool>> predicate);
}
