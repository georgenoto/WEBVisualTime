using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE90;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE90Service : IService<TABLE90Dto, CreateTABLE90Dto, UpdateTABLE90Dto, string>
{
    Task<IEnumerable<TABLE90Dto>> FindAsync(Expression<Func<TABLE90, bool>> predicate);
}
