using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7801;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7801Service : IService<TABLE7801Dto, CreateTABLE7801Dto, UpdateTABLE7801Dto, int>
{
    Task<IEnumerable<TABLE7801Dto>> FindAsync(Expression<Func<TABLE7801, bool>> predicate);
}
