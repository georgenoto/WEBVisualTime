using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8060;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8060Service : IService<TABLE8060Dto, CreateTABLE8060Dto, UpdateTABLE8060Dto, long>
{
    Task<IEnumerable<TABLE8060Dto>> FindAsync(Expression<Func<TABLE8060, bool>> predicate);
}
