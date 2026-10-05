using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE240;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE240Service : IService<TABLE240Dto, CreateTABLE240Dto, UpdateTABLE240Dto, int>
{
    Task<IEnumerable<TABLE240Dto>> FindAsync(Expression<Func<TABLE240, bool>> predicate);
}
