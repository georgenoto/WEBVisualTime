using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE400;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE400Service : IService<TABLE400Dto, CreateTABLE400Dto, UpdateTABLE400Dto, int>
{
    Task<IEnumerable<TABLE400Dto>> FindAsync(Expression<Func<TABLE400, bool>> predicate);
}
