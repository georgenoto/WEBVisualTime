using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE174;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE174Service : IService<TABLE174Dto, CreateTABLE174Dto, UpdateTABLE174Dto, int>
{
    Task<IEnumerable<TABLE174Dto>> FindAsync(Expression<Func<TABLE174, bool>> predicate);
}
