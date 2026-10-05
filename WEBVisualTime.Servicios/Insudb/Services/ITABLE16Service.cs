using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE16;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE16Service : IService<TABLE16Dto, CreateTABLE16Dto, UpdateTABLE16Dto, long>
{
    Task<IEnumerable<TABLE16Dto>> FindAsync(Expression<Func<TABLE16, bool>> predicate);
}
