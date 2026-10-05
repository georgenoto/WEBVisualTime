using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5598;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5598Service : IService<TABLE5598Dto, CreateTABLE5598Dto, UpdateTABLE5598Dto, int>
{
    Task<IEnumerable<TABLE5598Dto>> FindAsync(Expression<Func<TABLE5598, bool>> predicate);
}
