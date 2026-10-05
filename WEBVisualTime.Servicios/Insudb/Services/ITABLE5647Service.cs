using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5647;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5647Service : IService<TABLE5647Dto, CreateTABLE5647Dto, UpdateTABLE5647Dto, int>
{
    Task<IEnumerable<TABLE5647Dto>> FindAsync(Expression<Func<TABLE5647, bool>> predicate);
}
