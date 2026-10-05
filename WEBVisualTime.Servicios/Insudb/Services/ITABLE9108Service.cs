using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9108;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9108Service : IService<TABLE9108Dto, CreateTABLE9108Dto, UpdateTABLE9108Dto, int>
{
    Task<IEnumerable<TABLE9108Dto>> FindAsync(Expression<Func<TABLE9108, bool>> predicate);
}
