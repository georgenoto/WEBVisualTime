using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5749;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5749Service : IService<TABLE5749Dto, CreateTABLE5749Dto, UpdateTABLE5749Dto, int>
{
    Task<IEnumerable<TABLE5749Dto>> FindAsync(Expression<Func<TABLE5749, bool>> predicate);
}
