using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE269;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE269Service : IService<TABLE269Dto, CreateTABLE269Dto, UpdateTABLE269Dto, int>
{
    Task<IEnumerable<TABLE269Dto>> FindAsync(Expression<Func<TABLE269, bool>> predicate);
}
