using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9242;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9242Service : IService<TABLE9242Dto, CreateTABLE9242Dto, UpdateTABLE9242Dto, int>
{
    Task<IEnumerable<TABLE9242Dto>> FindAsync(Expression<Func<TABLE9242, bool>> predicate);
}
