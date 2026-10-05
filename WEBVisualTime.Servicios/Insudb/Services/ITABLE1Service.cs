using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE1Service : IService<TABLE1Dto, CreateTABLE1Dto, UpdateTABLE1Dto, long>
{
    Task<IEnumerable<TABLE1Dto>> FindAsync(Expression<Func<TABLE1, bool>> predicate);
}
