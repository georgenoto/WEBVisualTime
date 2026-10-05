using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6786;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6786Service : IService<TABLE6786Dto, CreateTABLE6786Dto, UpdateTABLE6786Dto, int>
{
    Task<IEnumerable<TABLE6786Dto>> FindAsync(Expression<Func<TABLE6786, bool>> predicate);
}
