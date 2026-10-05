using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9278;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9278Service : IService<TABLE9278Dto, CreateTABLE9278Dto, UpdateTABLE9278Dto, int>
{
    Task<IEnumerable<TABLE9278Dto>> FindAsync(Expression<Func<TABLE9278, bool>> predicate);
}
