using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5707;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5707Service : IService<TABLE5707Dto, CreateTABLE5707Dto, UpdateTABLE5707Dto, int>
{
    Task<IEnumerable<TABLE5707Dto>> FindAsync(Expression<Func<TABLE5707, bool>> predicate);
}
