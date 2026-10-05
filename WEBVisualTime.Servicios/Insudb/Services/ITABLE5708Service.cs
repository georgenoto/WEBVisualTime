using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5708;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5708Service : IService<TABLE5708Dto, CreateTABLE5708Dto, UpdateTABLE5708Dto, long>
{
    Task<IEnumerable<TABLE5708Dto>> FindAsync(Expression<Func<TABLE5708, bool>> predicate);
}
