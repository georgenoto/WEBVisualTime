using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7037;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7037Service : IService<TABLE7037Dto, CreateTABLE7037Dto, UpdateTABLE7037Dto, int>
{
    Task<IEnumerable<TABLE7037Dto>> FindAsync(Expression<Func<TABLE7037, bool>> predicate);
}
