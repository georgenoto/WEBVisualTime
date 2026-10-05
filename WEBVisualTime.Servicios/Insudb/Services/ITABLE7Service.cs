using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7Service : IService<TABLE7Dto, CreateTABLE7Dto, UpdateTABLE7Dto, long>
{
    Task<IEnumerable<TABLE7Dto>> FindAsync(Expression<Func<TABLE7, bool>> predicate);
}
