using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5546;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5546Service : IService<TABLE5546Dto, CreateTABLE5546Dto, UpdateTABLE5546Dto, int>
{
    Task<IEnumerable<TABLE5546Dto>> FindAsync(Expression<Func<TABLE5546, bool>> predicate);
}
