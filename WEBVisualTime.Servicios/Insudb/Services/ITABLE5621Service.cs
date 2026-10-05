using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5621;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5621Service : IService<TABLE5621Dto, CreateTABLE5621Dto, UpdateTABLE5621Dto, int>
{
    Task<IEnumerable<TABLE5621Dto>> FindAsync(Expression<Func<TABLE5621, bool>> predicate);
}
