using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6022;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6022Service : IService<TABLE6022Dto, CreateTABLE6022Dto, UpdateTABLE6022Dto, int>
{
    Task<IEnumerable<TABLE6022Dto>> FindAsync(Expression<Func<TABLE6022, bool>> predicate);
}
