using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE18Service : IService<TABLE18Dto, CreateTABLE18Dto, UpdateTABLE18Dto, string>
{
    Task<IEnumerable<TABLE18Dto>> FindAsync(Expression<Func<TABLE18, bool>> predicate);
}
