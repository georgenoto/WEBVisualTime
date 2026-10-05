using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9Service : IService<TABLE9Dto, CreateTABLE9Dto, UpdateTABLE9Dto, int>
{
    Task<IEnumerable<TABLE9Dto>> FindAsync(Expression<Func<TABLE9, bool>> predicate);
}
