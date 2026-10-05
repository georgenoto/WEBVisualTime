using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE73;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE73Service : IService<TABLE73Dto, CreateTABLE73Dto, UpdateTABLE73Dto, int>
{
    Task<IEnumerable<TABLE73Dto>> FindAsync(Expression<Func<TABLE73, bool>> predicate);
}
