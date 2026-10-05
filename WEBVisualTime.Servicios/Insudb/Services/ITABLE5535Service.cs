using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5535;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5535Service : IService<TABLE5535Dto, CreateTABLE5535Dto, UpdateTABLE5535Dto, int>
{
    Task<IEnumerable<TABLE5535Dto>> FindAsync(Expression<Func<TABLE5535, bool>> predicate);
}
