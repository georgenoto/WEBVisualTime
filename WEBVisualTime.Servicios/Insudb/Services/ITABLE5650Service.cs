using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5650;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5650Service : IService<TABLE5650Dto, CreateTABLE5650Dto, UpdateTABLE5650Dto, int>
{
    Task<IEnumerable<TABLE5650Dto>> FindAsync(Expression<Func<TABLE5650, bool>> predicate);
}
