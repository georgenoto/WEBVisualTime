using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE260;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE260Service : IService<TABLE260Dto, CreateTABLE260Dto, UpdateTABLE260Dto, long>
{
    Task<IEnumerable<TABLE260Dto>> FindAsync(Expression<Func<TABLE260, bool>> predicate);
}
