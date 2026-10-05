using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8500;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8500Service : IService<TABLE8500Dto, CreateTABLE8500Dto, UpdateTABLE8500Dto, int>
{
    Task<IEnumerable<TABLE8500Dto>> FindAsync(Expression<Func<TABLE8500, bool>> predicate);
}
