using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9024;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9024Service : IService<TABLE9024Dto, CreateTABLE9024Dto, UpdateTABLE9024Dto, int>
{
    Task<IEnumerable<TABLE9024Dto>> FindAsync(Expression<Func<TABLE9024, bool>> predicate);
}
