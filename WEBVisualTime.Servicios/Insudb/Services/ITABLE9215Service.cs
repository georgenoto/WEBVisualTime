using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9215Service : IService<TABLE9215Dto, CreateTABLE9215Dto, UpdateTABLE9215Dto, int>
{
    Task<IEnumerable<TABLE9215Dto>> FindAsync(Expression<Func<TABLE9215, bool>> predicate);
}
