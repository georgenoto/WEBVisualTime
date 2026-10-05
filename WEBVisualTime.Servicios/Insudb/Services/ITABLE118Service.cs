using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE118;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE118Service : IService<TABLE118Dto, CreateTABLE118Dto, UpdateTABLE118Dto, int>
{
    Task<IEnumerable<TABLE118Dto>> FindAsync(Expression<Func<TABLE118, bool>> predicate);
}
