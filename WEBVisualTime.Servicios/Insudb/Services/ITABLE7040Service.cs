using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7040;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7040Service : IService<TABLE7040Dto, CreateTABLE7040Dto, UpdateTABLE7040Dto, int>
{
    Task<IEnumerable<TABLE7040Dto>> FindAsync(Expression<Func<TABLE7040, bool>> predicate);
}
