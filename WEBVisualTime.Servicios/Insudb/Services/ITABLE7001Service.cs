using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7001;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7001Service : IService<TABLE7001Dto, CreateTABLE7001Dto, UpdateTABLE7001Dto, int>
{
    Task<IEnumerable<TABLE7001Dto>> FindAsync(Expression<Func<TABLE7001, bool>> predicate);
}
