using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6000;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6000Service : IService<TABLE6000Dto, CreateTABLE6000Dto, UpdateTABLE6000Dto, int>
{
    Task<IEnumerable<TABLE6000Dto>> FindAsync(Expression<Func<TABLE6000, bool>> predicate);
}
