using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE211;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE211Service : IService<TABLE211Dto, CreateTABLE211Dto, UpdateTABLE211Dto, int>
{
    Task<IEnumerable<TABLE211Dto>> FindAsync(Expression<Func<TABLE211, bool>> predicate);
}
