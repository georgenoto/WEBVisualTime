using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE692Service : IService<TABLE692Dto, CreateTABLE692Dto, UpdateTABLE692Dto, int>
{
    Task<IEnumerable<TABLE692Dto>> FindAsync(Expression<Func<TABLE692, bool>> predicate);
}
