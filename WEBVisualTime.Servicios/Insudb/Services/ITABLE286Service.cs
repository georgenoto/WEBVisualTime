using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE286;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE286Service : IService<TABLE286Dto, CreateTABLE286Dto, UpdateTABLE286Dto, long>
{
    Task<IEnumerable<TABLE286Dto>> FindAsync(Expression<Func<TABLE286, bool>> predicate);
}
