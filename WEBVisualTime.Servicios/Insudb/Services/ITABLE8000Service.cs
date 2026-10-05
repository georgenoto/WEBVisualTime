using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8000;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8000Service : IService<TABLE8000Dto, CreateTABLE8000Dto, UpdateTABLE8000Dto, int>
{
    Task<IEnumerable<TABLE8000Dto>> FindAsync(Expression<Func<TABLE8000, bool>> predicate);
}
