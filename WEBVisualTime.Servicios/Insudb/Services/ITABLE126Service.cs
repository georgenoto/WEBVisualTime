using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE126;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE126Service : IService<TABLE126Dto, CreateTABLE126Dto, UpdateTABLE126Dto, long>
{
    Task<IEnumerable<TABLE126Dto>> FindAsync(Expression<Func<TABLE126, bool>> predicate);
}
