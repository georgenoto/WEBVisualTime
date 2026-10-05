using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9213;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9213Service : IService<TABLE9213Dto, CreateTABLE9213Dto, UpdateTABLE9213Dto, int>
{
    Task<IEnumerable<TABLE9213Dto>> FindAsync(Expression<Func<TABLE9213, bool>> predicate);
}
