using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE561;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE561Service : IService<TABLE561Dto, CreateTABLE561Dto, UpdateTABLE561Dto, int>
{
    Task<IEnumerable<TABLE561Dto>> FindAsync(Expression<Func<TABLE561, bool>> predicate);
}
