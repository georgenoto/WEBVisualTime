using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE187;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE187Service : IService<TABLE187Dto, CreateTABLE187Dto, UpdateTABLE187Dto, int>
{
    Task<IEnumerable<TABLE187Dto>> FindAsync(Expression<Func<TABLE187, bool>> predicate);
}
