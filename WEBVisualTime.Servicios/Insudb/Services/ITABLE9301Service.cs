using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9301;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9301Service : IService<TABLE9301Dto, CreateTABLE9301Dto, UpdateTABLE9301Dto, int>
{
    Task<IEnumerable<TABLE9301Dto>> FindAsync(Expression<Func<TABLE9301, bool>> predicate);
}
