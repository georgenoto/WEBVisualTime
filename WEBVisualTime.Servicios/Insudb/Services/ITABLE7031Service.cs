using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7031;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7031Service : IService<TABLE7031Dto, CreateTABLE7031Dto, UpdateTABLE7031Dto, long>
{
    Task<IEnumerable<TABLE7031Dto>> FindAsync(Expression<Func<TABLE7031, bool>> predicate);
}
