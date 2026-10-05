using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE14;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE14Service : IService<TABLE14Dto, CreateTABLE14Dto, UpdateTABLE14Dto, int>
{
    Task<IEnumerable<TABLE14Dto>> FindAsync(Expression<Func<TABLE14, bool>> predicate);
}
