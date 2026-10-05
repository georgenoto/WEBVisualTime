using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8001;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8001Service : IService<TABLE8001Dto, CreateTABLE8001Dto, UpdateTABLE8001Dto, int>
{
    Task<IEnumerable<TABLE8001Dto>> FindAsync(Expression<Func<TABLE8001, bool>> predicate);
}
