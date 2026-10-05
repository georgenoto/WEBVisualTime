using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE85;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE85Service : IService<TABLE85Dto, CreateTABLE85Dto, UpdateTABLE85Dto, int>
{
    Task<IEnumerable<TABLE85Dto>> FindAsync(Expression<Func<TABLE85, bool>> predicate);
}
