using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9013;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9013Service : IService<TABLE9013Dto, CreateTABLE9013Dto, UpdateTABLE9013Dto, int>
{
    Task<IEnumerable<TABLE9013Dto>> FindAsync(Expression<Func<TABLE9013, bool>> predicate);
}
