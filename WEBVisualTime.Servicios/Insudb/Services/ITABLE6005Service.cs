using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6005;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6005Service : IService<TABLE6005Dto, CreateTABLE6005Dto, UpdateTABLE6005Dto, int>
{
    Task<IEnumerable<TABLE6005Dto>> FindAsync(Expression<Func<TABLE6005, bool>> predicate);
}
