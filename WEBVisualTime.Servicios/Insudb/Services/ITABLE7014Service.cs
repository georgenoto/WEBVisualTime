using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7014;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7014Service : IService<TABLE7014Dto, CreateTABLE7014Dto, UpdateTABLE7014Dto, long>
{
    Task<IEnumerable<TABLE7014Dto>> FindAsync(Expression<Func<TABLE7014, bool>> predicate);
}
