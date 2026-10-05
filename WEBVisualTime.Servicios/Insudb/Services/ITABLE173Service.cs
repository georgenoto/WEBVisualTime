using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE173;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE173Service : IService<TABLE173Dto, CreateTABLE173Dto, UpdateTABLE173Dto, int>
{
    Task<IEnumerable<TABLE173Dto>> FindAsync(Expression<Func<TABLE173, bool>> predicate);
}
