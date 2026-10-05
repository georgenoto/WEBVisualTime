using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE92;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE92Service : IService<TABLE92Dto, CreateTABLE92Dto, UpdateTABLE92Dto, string>
{
    Task<IEnumerable<TABLE92Dto>> FindAsync(Expression<Func<TABLE92, bool>> predicate);
}
