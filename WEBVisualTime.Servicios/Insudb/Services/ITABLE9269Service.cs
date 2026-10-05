using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9269;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9269Service : IService<TABLE9269Dto, CreateTABLE9269Dto, UpdateTABLE9269Dto, int>
{
    Task<IEnumerable<TABLE9269Dto>> FindAsync(Expression<Func<TABLE9269, bool>> predicate);
}
