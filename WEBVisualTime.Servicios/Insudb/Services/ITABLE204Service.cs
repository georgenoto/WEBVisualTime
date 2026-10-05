using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE204;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE204Service : IService<TABLE204Dto, CreateTABLE204Dto, UpdateTABLE204Dto, int>
{
    Task<IEnumerable<TABLE204Dto>> FindAsync(Expression<Func<TABLE204, bool>> predicate);
}
