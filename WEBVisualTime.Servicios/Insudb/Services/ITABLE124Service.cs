using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE124;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE124Service : IService<TABLE124Dto, CreateTABLE124Dto, UpdateTABLE124Dto, long>
{
    Task<IEnumerable<TABLE124Dto>> FindAsync(Expression<Func<TABLE124, bool>> predicate);
}
