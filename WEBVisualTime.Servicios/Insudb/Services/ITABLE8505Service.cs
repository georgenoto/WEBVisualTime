using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8505;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8505Service : IService<TABLE8505Dto, CreateTABLE8505Dto, UpdateTABLE8505Dto, int>
{
    Task<IEnumerable<TABLE8505Dto>> FindAsync(Expression<Func<TABLE8505, bool>> predicate);
}
