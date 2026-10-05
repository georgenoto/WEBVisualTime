using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6046;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6046Service : IService<TABLE6046Dto, CreateTABLE6046Dto, UpdateTABLE6046Dto, int>
{
    Task<IEnumerable<TABLE6046Dto>> FindAsync(Expression<Func<TABLE6046, bool>> predicate);
}
