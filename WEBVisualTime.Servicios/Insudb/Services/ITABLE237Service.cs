using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE237;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE237Service : IService<TABLE237Dto, CreateTABLE237Dto, UpdateTABLE237Dto, int>
{
    Task<IEnumerable<TABLE237Dto>> FindAsync(Expression<Func<TABLE237, bool>> predicate);
}
