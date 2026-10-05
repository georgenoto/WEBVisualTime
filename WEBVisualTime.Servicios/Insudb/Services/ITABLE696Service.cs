using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE696;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE696Service : IService<TABLE696Dto, CreateTABLE696Dto, UpdateTABLE696Dto, int>
{
    Task<IEnumerable<TABLE696Dto>> FindAsync(Expression<Func<TABLE696, bool>> predicate);
}
