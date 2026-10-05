using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8003;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8003Service : IService<TABLE8003Dto, CreateTABLE8003Dto, UpdateTABLE8003Dto, int>
{
    Task<IEnumerable<TABLE8003Dto>> FindAsync(Expression<Func<TABLE8003, bool>> predicate);
}
