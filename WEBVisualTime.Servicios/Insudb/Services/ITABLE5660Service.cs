using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5660;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5660Service : IService<TABLE5660Dto, CreateTABLE5660Dto, UpdateTABLE5660Dto, int>
{
    Task<IEnumerable<TABLE5660Dto>> FindAsync(Expression<Func<TABLE5660, bool>> predicate);
}
