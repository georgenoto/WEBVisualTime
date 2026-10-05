using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE159;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE159Service : IService<TABLE159Dto, CreateTABLE159Dto, UpdateTABLE159Dto, int>
{
    Task<IEnumerable<TABLE159Dto>> FindAsync(Expression<Func<TABLE159, bool>> predicate);
}
