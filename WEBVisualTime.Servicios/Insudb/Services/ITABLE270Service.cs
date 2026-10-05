using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE270;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE270Service : IService<TABLE270Dto, CreateTABLE270Dto, UpdateTABLE270Dto, int>
{
    Task<IEnumerable<TABLE270Dto>> FindAsync(Expression<Func<TABLE270, bool>> predicate);
}
