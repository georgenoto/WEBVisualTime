using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5604;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5604Service : IService<TABLE5604Dto, CreateTABLE5604Dto, UpdateTABLE5604Dto, int>
{
    Task<IEnumerable<TABLE5604Dto>> FindAsync(Expression<Func<TABLE5604, bool>> predicate);
}
