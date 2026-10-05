using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7051;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7051Service : IService<TABLE7051Dto, CreateTABLE7051Dto, UpdateTABLE7051Dto, long>
{
    Task<IEnumerable<TABLE7051Dto>> FindAsync(Expression<Func<TABLE7051, bool>> predicate);
}
