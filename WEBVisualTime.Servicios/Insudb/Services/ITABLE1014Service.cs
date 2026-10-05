using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1014;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE1014Service : IService<TABLE1014Dto, CreateTABLE1014Dto, UpdateTABLE1014Dto, int>
{
    Task<IEnumerable<TABLE1014Dto>> FindAsync(Expression<Func<TABLE1014, bool>> predicate);
}
