using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7501;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7501Service : IService<TABLE7501Dto, CreateTABLE7501Dto, UpdateTABLE7501Dto, long>
{
    Task<IEnumerable<TABLE7501Dto>> FindAsync(Expression<Func<TABLE7501, bool>> predicate);
}
