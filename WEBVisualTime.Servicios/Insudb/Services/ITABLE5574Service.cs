using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5574;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5574Service : IService<TABLE5574Dto, CreateTABLE5574Dto, UpdateTABLE5574Dto, int>
{
    Task<IEnumerable<TABLE5574Dto>> FindAsync(Expression<Func<TABLE5574, bool>> predicate);
}
