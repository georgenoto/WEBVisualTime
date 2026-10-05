using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE184;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE184Service : IService<TABLE184Dto, CreateTABLE184Dto, UpdateTABLE184Dto, int>
{
    Task<IEnumerable<TABLE184Dto>> FindAsync(Expression<Func<TABLE184, bool>> predicate);
}
