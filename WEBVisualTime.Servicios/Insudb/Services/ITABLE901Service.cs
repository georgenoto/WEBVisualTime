using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE901;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE901Service : IService<TABLE901Dto, CreateTABLE901Dto, UpdateTABLE901Dto, long>
{
    Task<IEnumerable<TABLE901Dto>> FindAsync(Expression<Func<TABLE901, bool>> predicate);
}
