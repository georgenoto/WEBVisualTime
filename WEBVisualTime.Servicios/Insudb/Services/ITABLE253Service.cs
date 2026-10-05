using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE253;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE253Service : IService<TABLE253Dto, CreateTABLE253Dto, UpdateTABLE253Dto, int>
{
    Task<IEnumerable<TABLE253Dto>> FindAsync(Expression<Func<TABLE253, bool>> predicate);
}
