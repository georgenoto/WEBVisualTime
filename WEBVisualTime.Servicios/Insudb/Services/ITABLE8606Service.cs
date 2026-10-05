using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8606;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8606Service : IService<TABLE8606Dto, CreateTABLE8606Dto, UpdateTABLE8606Dto, int>
{
    Task<IEnumerable<TABLE8606Dto>> FindAsync(Expression<Func<TABLE8606, bool>> predicate);
}
