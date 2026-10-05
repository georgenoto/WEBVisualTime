using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8300;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8300Service : IService<TABLE8300Dto, CreateTABLE8300Dto, UpdateTABLE8300Dto, int>
{
    Task<IEnumerable<TABLE8300Dto>> FindAsync(Expression<Func<TABLE8300, bool>> predicate);
}
