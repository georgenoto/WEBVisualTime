using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE416;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE416Service : IService<TABLE416Dto, CreateTABLE416Dto, UpdateTABLE416Dto, long>
{
    Task<IEnumerable<TABLE416Dto>> FindAsync(Expression<Func<TABLE416, bool>> predicate);
}
