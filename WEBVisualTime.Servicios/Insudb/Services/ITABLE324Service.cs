using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE324;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE324Service : IService<TABLE324Dto, CreateTABLE324Dto, UpdateTABLE324Dto, int>
{
    Task<IEnumerable<TABLE324Dto>> FindAsync(Expression<Func<TABLE324, bool>> predicate);
}
