using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5700;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5700Service : IService<TABLE5700Dto, CreateTABLE5700Dto, UpdateTABLE5700Dto, int>
{
    Task<IEnumerable<TABLE5700Dto>> FindAsync(Expression<Func<TABLE5700, bool>> predicate);
}
