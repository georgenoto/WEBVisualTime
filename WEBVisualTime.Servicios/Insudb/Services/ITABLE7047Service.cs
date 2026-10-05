using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7047;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7047Service : IService<TABLE7047Dto, CreateTABLE7047Dto, UpdateTABLE7047Dto, int>
{
    Task<IEnumerable<TABLE7047Dto>> FindAsync(Expression<Func<TABLE7047, bool>> predicate);
}
