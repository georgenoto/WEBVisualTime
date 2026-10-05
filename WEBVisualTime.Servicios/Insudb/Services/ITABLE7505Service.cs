using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7505;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7505Service : IService<TABLE7505Dto, CreateTABLE7505Dto, UpdateTABLE7505Dto, string>
{
    Task<IEnumerable<TABLE7505Dto>> FindAsync(Expression<Func<TABLE7505, bool>> predicate);
}
