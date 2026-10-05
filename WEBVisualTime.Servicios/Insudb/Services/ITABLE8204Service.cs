using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8204;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8204Service : IService<TABLE8204Dto, CreateTABLE8204Dto, UpdateTABLE8204Dto, string>
{
    Task<IEnumerable<TABLE8204Dto>> FindAsync(Expression<Func<TABLE8204, bool>> predicate);
}
