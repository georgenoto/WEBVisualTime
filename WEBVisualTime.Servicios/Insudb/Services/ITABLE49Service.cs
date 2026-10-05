using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE49;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE49Service : IService<TABLE49Dto, CreateTABLE49Dto, UpdateTABLE49Dto, string>
{
    Task<IEnumerable<TABLE49Dto>> FindAsync(Expression<Func<TABLE49, bool>> predicate);
}
