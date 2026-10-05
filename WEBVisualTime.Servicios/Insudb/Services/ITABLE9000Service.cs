using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9000;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9000Service : IService<TABLE9000Dto, CreateTABLE9000Dto, UpdateTABLE9000Dto, int>
{
    Task<IEnumerable<TABLE9000Dto>> FindAsync(Expression<Func<TABLE9000, bool>> predicate);
}
