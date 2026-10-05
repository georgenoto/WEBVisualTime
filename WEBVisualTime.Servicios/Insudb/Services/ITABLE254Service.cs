using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE254;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE254Service : IService<TABLE254Dto, CreateTABLE254Dto, UpdateTABLE254Dto, long>
{
    Task<IEnumerable<TABLE254Dto>> FindAsync(Expression<Func<TABLE254, bool>> predicate);
}
