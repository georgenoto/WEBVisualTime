using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7039;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7039Service : IService<TABLE7039Dto, CreateTABLE7039Dto, UpdateTABLE7039Dto, int>
{
    Task<IEnumerable<TABLE7039Dto>> FindAsync(Expression<Func<TABLE7039, bool>> predicate);
}
