using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5902;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5902Service : IService<TABLE5902Dto, CreateTABLE5902Dto, UpdateTABLE5902Dto, int>
{
    Task<IEnumerable<TABLE5902Dto>> FindAsync(Expression<Func<TABLE5902, bool>> predicate);
}
