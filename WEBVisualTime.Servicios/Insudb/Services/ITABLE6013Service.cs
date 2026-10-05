using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6013;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6013Service : IService<TABLE6013Dto, CreateTABLE6013Dto, UpdateTABLE6013Dto, int>
{
    Task<IEnumerable<TABLE6013Dto>> FindAsync(Expression<Func<TABLE6013, bool>> predicate);
}
