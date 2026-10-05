using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5705;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5705Service : IService<TABLE5705Dto, CreateTABLE5705Dto, UpdateTABLE5705Dto, int>
{
    Task<IEnumerable<TABLE5705Dto>> FindAsync(Expression<Func<TABLE5705, bool>> predicate);
}
