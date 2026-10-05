using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5673;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5673Service : IService<TABLE5673Dto, CreateTABLE5673Dto, UpdateTABLE5673Dto, int>
{
    Task<IEnumerable<TABLE5673Dto>> FindAsync(Expression<Func<TABLE5673, bool>> predicate);
}
