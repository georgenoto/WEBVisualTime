using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7013;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7013Service : IService<TABLE7013Dto, CreateTABLE7013Dto, UpdateTABLE7013Dto, long>
{
    Task<IEnumerable<TABLE7013Dto>> FindAsync(Expression<Func<TABLE7013, bool>> predicate);
}
