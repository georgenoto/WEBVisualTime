using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9253;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9253Service : IService<TABLE9253Dto, CreateTABLE9253Dto, UpdateTABLE9253Dto, int>
{
    Task<IEnumerable<TABLE9253Dto>> FindAsync(Expression<Func<TABLE9253, bool>> predicate);
}
