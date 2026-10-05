using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE249;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE249Service : IService<TABLE249Dto, CreateTABLE249Dto, UpdateTABLE249Dto, long>
{
    Task<IEnumerable<TABLE249Dto>> FindAsync(Expression<Func<TABLE249, bool>> predicate);
}
