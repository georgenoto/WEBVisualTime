using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7003;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7003Service : IService<TABLE7003Dto, CreateTABLE7003Dto, UpdateTABLE7003Dto, int>
{
    Task<IEnumerable<TABLE7003Dto>> FindAsync(Expression<Func<TABLE7003, bool>> predicate);
}
