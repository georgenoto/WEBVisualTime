using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE105;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE105Service : IService<TABLE105Dto, CreateTABLE105Dto, UpdateTABLE105Dto, string>
{
    Task<IEnumerable<TABLE105Dto>> FindAsync(Expression<Func<TABLE105, bool>> predicate);
}
