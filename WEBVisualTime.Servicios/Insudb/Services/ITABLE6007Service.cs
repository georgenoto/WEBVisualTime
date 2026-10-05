using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6007;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6007Service : IService<TABLE6007Dto, CreateTABLE6007Dto, UpdateTABLE6007Dto, int>
{
    Task<IEnumerable<TABLE6007Dto>> FindAsync(Expression<Func<TABLE6007, bool>> predicate);
}
