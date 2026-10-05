using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6004;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6004Service : IService<TABLE6004Dto, CreateTABLE6004Dto, UpdateTABLE6004Dto, int>
{
    Task<IEnumerable<TABLE6004Dto>> FindAsync(Expression<Func<TABLE6004, bool>> predicate);
}
