using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9274;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9274Service : IService<TABLE9274Dto, CreateTABLE9274Dto, UpdateTABLE9274Dto, int>
{
    Task<IEnumerable<TABLE9274Dto>> FindAsync(Expression<Func<TABLE9274, bool>> predicate);
}
