using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE196;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE196Service : IService<TABLE196Dto, CreateTABLE196Dto, UpdateTABLE196Dto, long>
{
    Task<IEnumerable<TABLE196Dto>> FindAsync(Expression<Func<TABLE196, bool>> predicate);
}
