using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE23;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE23Service : IService<TABLE23Dto, CreateTABLE23Dto, UpdateTABLE23Dto, long>
{
    Task<IEnumerable<TABLE23Dto>> FindAsync(Expression<Func<TABLE23, bool>> predicate);
}
