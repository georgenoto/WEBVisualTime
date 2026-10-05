using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE64;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE64Service : IService<TABLE64Dto, CreateTABLE64Dto, UpdateTABLE64Dto, string>
{
    Task<IEnumerable<TABLE64Dto>> FindAsync(Expression<Func<TABLE64, bool>> predicate);
}
