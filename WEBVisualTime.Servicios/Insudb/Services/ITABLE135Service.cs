using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE135;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE135Service : IService<TABLE135Dto, CreateTABLE135Dto, UpdateTABLE135Dto, string>
{
    Task<IEnumerable<TABLE135Dto>> FindAsync(Expression<Func<TABLE135, bool>> predicate);
}
