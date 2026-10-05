using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE215;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE215Service : IService<TABLE215Dto, CreateTABLE215Dto, UpdateTABLE215Dto, int>
{
    Task<IEnumerable<TABLE215Dto>> FindAsync(Expression<Func<TABLE215, bool>> predicate);
}
