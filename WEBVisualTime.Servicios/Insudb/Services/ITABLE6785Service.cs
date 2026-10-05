using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6785;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6785Service : IService<TABLE6785Dto, CreateTABLE6785Dto, UpdateTABLE6785Dto, int>
{
    Task<IEnumerable<TABLE6785Dto>> FindAsync(Expression<Func<TABLE6785, bool>> predicate);
}
