using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9006;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9006Service : IService<TABLE9006Dto, CreateTABLE9006Dto, UpdateTABLE9006Dto, int>
{
    Task<IEnumerable<TABLE9006Dto>> FindAsync(Expression<Func<TABLE9006, bool>> predicate);
}
