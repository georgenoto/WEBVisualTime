using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6335;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6335Service : IService<TABLE6335Dto, CreateTABLE6335Dto, UpdateTABLE6335Dto, int>
{
    Task<IEnumerable<TABLE6335Dto>> FindAsync(Expression<Func<TABLE6335, bool>> predicate);
}
