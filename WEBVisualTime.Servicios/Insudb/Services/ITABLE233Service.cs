using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE233;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE233Service : IService<TABLE233Dto, CreateTABLE233Dto, UpdateTABLE233Dto, int>
{
    Task<IEnumerable<TABLE233Dto>> FindAsync(Expression<Func<TABLE233, bool>> predicate);
}
