using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6071;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6071Service : IService<TABLE6071Dto, CreateTABLE6071Dto, UpdateTABLE6071Dto, int>
{
    Task<IEnumerable<TABLE6071Dto>> FindAsync(Expression<Func<TABLE6071, bool>> predicate);
}
