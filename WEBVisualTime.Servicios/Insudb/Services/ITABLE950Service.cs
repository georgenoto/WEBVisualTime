using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE950;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE950Service : IService<TABLE950Dto, CreateTABLE950Dto, UpdateTABLE950Dto, long>
{
    Task<IEnumerable<TABLE950Dto>> FindAsync(Expression<Func<TABLE950, bool>> predicate);
}
