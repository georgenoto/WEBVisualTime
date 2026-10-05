using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE526;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE526Service : IService<TABLE526Dto, CreateTABLE526Dto, UpdateTABLE526Dto, int>
{
    Task<IEnumerable<TABLE526Dto>> FindAsync(Expression<Func<TABLE526, bool>> predicate);
}
