using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6072;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6072Service : IService<TABLE6072Dto, CreateTABLE6072Dto, UpdateTABLE6072Dto, int>
{
    Task<IEnumerable<TABLE6072Dto>> FindAsync(Expression<Func<TABLE6072, bool>> predicate);
}
