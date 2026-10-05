using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9016;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9016Service : IService<TABLE9016Dto, CreateTABLE9016Dto, UpdateTABLE9016Dto, int>
{
    Task<IEnumerable<TABLE9016Dto>> FindAsync(Expression<Func<TABLE9016, bool>> predicate);
}
