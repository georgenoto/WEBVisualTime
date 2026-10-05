using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE418;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE418Service : IService<TABLE418Dto, CreateTABLE418Dto, UpdateTABLE418Dto, long>
{
    Task<IEnumerable<TABLE418Dto>> FindAsync(Expression<Func<TABLE418, bool>> predicate);
}
