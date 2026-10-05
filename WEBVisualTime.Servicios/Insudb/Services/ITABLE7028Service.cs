using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7028;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7028Service : IService<TABLE7028Dto, CreateTABLE7028Dto, UpdateTABLE7028Dto, long>
{
    Task<IEnumerable<TABLE7028Dto>> FindAsync(Expression<Func<TABLE7028, bool>> predicate);
}
