using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9229;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9229Service : IService<TABLE9229Dto, CreateTABLE9229Dto, UpdateTABLE9229Dto, int>
{
    Task<IEnumerable<TABLE9229Dto>> FindAsync(Expression<Func<TABLE9229, bool>> predicate);
}
