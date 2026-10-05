using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5641;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5641Service : IService<TABLE5641Dto, CreateTABLE5641Dto, UpdateTABLE5641Dto, int>
{
    Task<IEnumerable<TABLE5641Dto>> FindAsync(Expression<Func<TABLE5641, bool>> predicate);
}
