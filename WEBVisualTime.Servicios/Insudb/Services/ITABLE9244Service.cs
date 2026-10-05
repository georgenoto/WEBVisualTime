using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9244;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9244Service : IService<TABLE9244Dto, CreateTABLE9244Dto, UpdateTABLE9244Dto, int>
{
    Task<IEnumerable<TABLE9244Dto>> FindAsync(Expression<Func<TABLE9244, bool>> predicate);
}
