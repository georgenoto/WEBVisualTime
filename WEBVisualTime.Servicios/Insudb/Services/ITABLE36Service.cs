using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE36Service : IService<TABLE36Dto, CreateTABLE36Dto, UpdateTABLE36Dto, int>
{
    Task<IEnumerable<TABLE36Dto>> FindAsync(Expression<Func<TABLE36, bool>> predicate);
}
