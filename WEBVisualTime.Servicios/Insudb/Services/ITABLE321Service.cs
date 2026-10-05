using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE321;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE321Service : IService<TABLE321Dto, CreateTABLE321Dto, UpdateTABLE321Dto, int>
{
    Task<IEnumerable<TABLE321Dto>> FindAsync(Expression<Func<TABLE321, bool>> predicate);
}
