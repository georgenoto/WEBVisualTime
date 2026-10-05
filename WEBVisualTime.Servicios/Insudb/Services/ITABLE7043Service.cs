using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7043;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7043Service : IService<TABLE7043Dto, CreateTABLE7043Dto, UpdateTABLE7043Dto, long>
{
    Task<IEnumerable<TABLE7043Dto>> FindAsync(Expression<Func<TABLE7043, bool>> predicate);
}
