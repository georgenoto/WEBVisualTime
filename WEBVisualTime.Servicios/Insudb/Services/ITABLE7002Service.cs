using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7002;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7002Service : IService<TABLE7002Dto, CreateTABLE7002Dto, UpdateTABLE7002Dto, int>
{
    Task<IEnumerable<TABLE7002Dto>> FindAsync(Expression<Func<TABLE7002, bool>> predicate);
}
