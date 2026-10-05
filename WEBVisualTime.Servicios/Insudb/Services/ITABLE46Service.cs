using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE46;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE46Service : IService<TABLE46Dto, CreateTABLE46Dto, UpdateTABLE46Dto, string>
{
    Task<IEnumerable<TABLE46Dto>> FindAsync(Expression<Func<TABLE46, bool>> predicate);
}
