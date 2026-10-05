using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6900;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6900Service : IService<TABLE6900Dto, CreateTABLE6900Dto, UpdateTABLE6900Dto, int>
{
    Task<IEnumerable<TABLE6900Dto>> FindAsync(Expression<Func<TABLE6900, bool>> predicate);
}
