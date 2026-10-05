using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE151;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE151Service : IService<TABLE151Dto, CreateTABLE151Dto, UpdateTABLE151Dto, int>
{
    Task<IEnumerable<TABLE151Dto>> FindAsync(Expression<Func<TABLE151, bool>> predicate);
}
