using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9233;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9233Service : IService<TABLE9233Dto, CreateTABLE9233Dto, UpdateTABLE9233Dto, string>
{
    Task<IEnumerable<TABLE9233Dto>> FindAsync(Expression<Func<TABLE9233, bool>> predicate);
}
