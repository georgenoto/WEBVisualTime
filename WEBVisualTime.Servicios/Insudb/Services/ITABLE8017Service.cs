using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8017;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8017Service : IService<TABLE8017Dto, CreateTABLE8017Dto, UpdateTABLE8017Dto, int>
{
    Task<IEnumerable<TABLE8017Dto>> FindAsync(Expression<Func<TABLE8017, bool>> predicate);
}
