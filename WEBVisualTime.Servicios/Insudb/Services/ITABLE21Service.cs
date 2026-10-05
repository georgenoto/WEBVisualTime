using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE21;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE21Service : IService<TABLE21Dto, CreateTABLE21Dto, UpdateTABLE21Dto, long>
{
    Task<IEnumerable<TABLE21Dto>> FindAsync(Expression<Func<TABLE21, bool>> predicate);
}
