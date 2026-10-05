using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE527;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE527Service : IService<TABLE527Dto, CreateTABLE527Dto, UpdateTABLE527Dto, int>
{
    Task<IEnumerable<TABLE527Dto>> FindAsync(Expression<Func<TABLE527, bool>> predicate);
}
