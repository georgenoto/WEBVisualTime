using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6034;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6034Service : IService<TABLE6034Dto, CreateTABLE6034Dto, UpdateTABLE6034Dto, int>
{
    Task<IEnumerable<TABLE6034Dto>> FindAsync(Expression<Func<TABLE6034, bool>> predicate);
}
