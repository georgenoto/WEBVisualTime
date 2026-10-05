using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5505;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5505Service : IService<TABLE5505Dto, CreateTABLE5505Dto, UpdateTABLE5505Dto, int>
{
    Task<IEnumerable<TABLE5505Dto>> FindAsync(Expression<Func<TABLE5505, bool>> predicate);
}
