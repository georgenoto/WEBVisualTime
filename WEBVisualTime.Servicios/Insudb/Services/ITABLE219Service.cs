using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE219;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE219Service : IService<TABLE219Dto, CreateTABLE219Dto, UpdateTABLE219Dto, long>
{
    Task<IEnumerable<TABLE219Dto>> FindAsync(Expression<Func<TABLE219, bool>> predicate);
}
