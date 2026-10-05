using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9246;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9246Service : IService<TABLE9246Dto, CreateTABLE9246Dto, UpdateTABLE9246Dto, int>
{
    Task<IEnumerable<TABLE9246Dto>> FindAsync(Expression<Func<TABLE9246, bool>> predicate);
}
