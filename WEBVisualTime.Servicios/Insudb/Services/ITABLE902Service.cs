using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE902;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE902Service : IService<TABLE902Dto, CreateTABLE902Dto, UpdateTABLE902Dto, long>
{
    Task<IEnumerable<TABLE902Dto>> FindAsync(Expression<Func<TABLE902, bool>> predicate);
}
