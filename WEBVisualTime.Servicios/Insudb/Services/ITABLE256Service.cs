using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE256;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE256Service : IService<TABLE256Dto, CreateTABLE256Dto, UpdateTABLE256Dto, long>
{
    Task<IEnumerable<TABLE256Dto>> FindAsync(Expression<Func<TABLE256, bool>> predicate);
}
