using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9218;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9218Service : IService<TABLE9218Dto, CreateTABLE9218Dto, UpdateTABLE9218Dto, int>
{
    Task<IEnumerable<TABLE9218Dto>> FindAsync(Expression<Func<TABLE9218, bool>> predicate);
}
