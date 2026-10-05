using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE197;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE197Service : IService<TABLE197Dto, CreateTABLE197Dto, UpdateTABLE197Dto, int>
{
    Task<IEnumerable<TABLE197Dto>> FindAsync(Expression<Func<TABLE197, bool>> predicate);
}
