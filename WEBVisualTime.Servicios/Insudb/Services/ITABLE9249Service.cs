using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9249;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9249Service : IService<TABLE9249Dto, CreateTABLE9249Dto, UpdateTABLE9249Dto, int>
{
    Task<IEnumerable<TABLE9249Dto>> FindAsync(Expression<Func<TABLE9249, bool>> predicate);
}
