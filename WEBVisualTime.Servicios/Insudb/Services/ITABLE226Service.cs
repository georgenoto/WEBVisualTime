using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE226;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE226Service : IService<TABLE226Dto, CreateTABLE226Dto, UpdateTABLE226Dto, int>
{
    Task<IEnumerable<TABLE226Dto>> FindAsync(Expression<Func<TABLE226, bool>> predicate);
}
