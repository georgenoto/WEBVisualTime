using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9279;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9279Service : IService<TABLE9279Dto, CreateTABLE9279Dto, UpdateTABLE9279Dto, int>
{
    Task<IEnumerable<TABLE9279Dto>> FindAsync(Expression<Func<TABLE9279, bool>> predicate);
}
