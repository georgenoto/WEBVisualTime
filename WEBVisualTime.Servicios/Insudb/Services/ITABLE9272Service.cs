using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9272;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9272Service : IService<TABLE9272Dto, CreateTABLE9272Dto, UpdateTABLE9272Dto, int>
{
    Task<IEnumerable<TABLE9272Dto>> FindAsync(Expression<Func<TABLE9272, bool>> predicate);
}
