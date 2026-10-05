using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6023;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6023Service : IService<TABLE6023Dto, CreateTABLE6023Dto, UpdateTABLE6023Dto, int>
{
    Task<IEnumerable<TABLE6023Dto>> FindAsync(Expression<Func<TABLE6023, bool>> predicate);
}
