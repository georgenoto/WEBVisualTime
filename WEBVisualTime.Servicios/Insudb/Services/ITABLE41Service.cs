using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE41;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE41Service : IService<TABLE41Dto, CreateTABLE41Dto, UpdateTABLE41Dto, long>
{
    Task<IEnumerable<TABLE41Dto>> FindAsync(Expression<Func<TABLE41, bool>> predicate);
}
