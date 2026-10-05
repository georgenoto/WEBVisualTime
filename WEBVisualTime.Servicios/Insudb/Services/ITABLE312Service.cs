using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE312;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE312Service : IService<TABLE312Dto, CreateTABLE312Dto, UpdateTABLE312Dto, int>
{
    Task<IEnumerable<TABLE312Dto>> FindAsync(Expression<Func<TABLE312, bool>> predicate);
}
