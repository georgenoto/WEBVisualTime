using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6059;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6059Service : IService<TABLE6059Dto, CreateTABLE6059Dto, UpdateTABLE6059Dto, int>
{
    Task<IEnumerable<TABLE6059Dto>> FindAsync(Expression<Func<TABLE6059, bool>> predicate);
}
