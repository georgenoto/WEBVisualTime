using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6100;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6100Service : IService<TABLE6100Dto, CreateTABLE6100Dto, UpdateTABLE6100Dto, int>
{
    Task<IEnumerable<TABLE6100Dto>> FindAsync(Expression<Func<TABLE6100, bool>> predicate);
}
