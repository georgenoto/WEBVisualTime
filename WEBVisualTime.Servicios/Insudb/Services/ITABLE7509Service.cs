using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7509;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7509Service : IService<TABLE7509Dto, CreateTABLE7509Dto, UpdateTABLE7509Dto, int>
{
    Task<IEnumerable<TABLE7509Dto>> FindAsync(Expression<Func<TABLE7509, bool>> predicate);
}
