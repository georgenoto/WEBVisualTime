using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE994;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE994Service : IService<TABLE994Dto, CreateTABLE994Dto, UpdateTABLE994Dto, int>
{
    Task<IEnumerable<TABLE994Dto>> FindAsync(Expression<Func<TABLE994, bool>> predicate);
}
