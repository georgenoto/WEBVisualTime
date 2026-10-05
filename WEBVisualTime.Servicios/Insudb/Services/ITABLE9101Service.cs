using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9101;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9101Service : IService<TABLE9101Dto, CreateTABLE9101Dto, UpdateTABLE9101Dto, int>
{
    Task<IEnumerable<TABLE9101Dto>> FindAsync(Expression<Func<TABLE9101, bool>> predicate);
}
