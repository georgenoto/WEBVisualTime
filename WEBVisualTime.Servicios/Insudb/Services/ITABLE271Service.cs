using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE271;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE271Service : IService<TABLE271Dto, CreateTABLE271Dto, UpdateTABLE271Dto, int>
{
    Task<IEnumerable<TABLE271Dto>> FindAsync(Expression<Func<TABLE271, bool>> predicate);
}
