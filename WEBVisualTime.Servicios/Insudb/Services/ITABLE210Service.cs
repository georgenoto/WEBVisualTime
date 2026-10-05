using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE210;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE210Service : IService<TABLE210Dto, CreateTABLE210Dto, UpdateTABLE210Dto, int>
{
    Task<IEnumerable<TABLE210Dto>> FindAsync(Expression<Func<TABLE210, bool>> predicate);
}
