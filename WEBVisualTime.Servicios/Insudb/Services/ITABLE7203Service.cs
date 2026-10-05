using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7203;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7203Service : IService<TABLE7203Dto, CreateTABLE7203Dto, UpdateTABLE7203Dto, long>
{
    Task<IEnumerable<TABLE7203Dto>> FindAsync(Expression<Func<TABLE7203, bool>> predicate);
}
