using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9266;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9266Service : IService<TABLE9266Dto, CreateTABLE9266Dto, UpdateTABLE9266Dto, int>
{
    Task<IEnumerable<TABLE9266Dto>> FindAsync(Expression<Func<TABLE9266, bool>> predicate);
}
