using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE222;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE222Service : IService<TABLE222Dto, CreateTABLE222Dto, UpdateTABLE222Dto, int>
{
    Task<IEnumerable<TABLE222Dto>> FindAsync(Expression<Func<TABLE222, bool>> predicate);
}
