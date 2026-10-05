using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE32;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE32Service : IService<TABLE32Dto, CreateTABLE32Dto, UpdateTABLE32Dto, int>
{
    Task<IEnumerable<TABLE32Dto>> FindAsync(Expression<Func<TABLE32, bool>> predicate);
}
