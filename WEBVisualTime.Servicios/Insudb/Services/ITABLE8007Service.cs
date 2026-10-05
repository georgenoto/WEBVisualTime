using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8007;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8007Service : IService<TABLE8007Dto, CreateTABLE8007Dto, UpdateTABLE8007Dto, int>
{
    Task<IEnumerable<TABLE8007Dto>> FindAsync(Expression<Func<TABLE8007, bool>> predicate);
}
