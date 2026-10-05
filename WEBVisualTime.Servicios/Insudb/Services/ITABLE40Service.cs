using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE40;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE40Service : IService<TABLE40Dto, CreateTABLE40Dto, UpdateTABLE40Dto, long>
{
    Task<IEnumerable<TABLE40Dto>> FindAsync(Expression<Func<TABLE40, bool>> predicate);
}
