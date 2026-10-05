using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5529;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5529Service : IService<TABLE5529Dto, CreateTABLE5529Dto, UpdateTABLE5529Dto, int>
{
    Task<IEnumerable<TABLE5529Dto>> FindAsync(Expression<Func<TABLE5529, bool>> predicate);
}
