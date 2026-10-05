using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8215;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8215Service : IService<TABLE8215Dto, CreateTABLE8215Dto, UpdateTABLE8215Dto, int>
{
    Task<IEnumerable<TABLE8215Dto>> FindAsync(Expression<Func<TABLE8215, bool>> predicate);
}
