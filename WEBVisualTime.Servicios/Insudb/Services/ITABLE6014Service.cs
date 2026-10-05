using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6014;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6014Service : IService<TABLE6014Dto, CreateTABLE6014Dto, UpdateTABLE6014Dto, int>
{
    Task<IEnumerable<TABLE6014Dto>> FindAsync(Expression<Func<TABLE6014, bool>> predicate);
}
