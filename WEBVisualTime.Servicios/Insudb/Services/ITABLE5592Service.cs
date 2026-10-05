using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5592;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5592Service : IService<TABLE5592Dto, CreateTABLE5592Dto, UpdateTABLE5592Dto, int>
{
    Task<IEnumerable<TABLE5592Dto>> FindAsync(Expression<Func<TABLE5592, bool>> predicate);
}
