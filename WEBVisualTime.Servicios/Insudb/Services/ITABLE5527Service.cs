using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5527;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5527Service : IService<TABLE5527Dto, CreateTABLE5527Dto, UpdateTABLE5527Dto, int>
{
    Task<IEnumerable<TABLE5527Dto>> FindAsync(Expression<Func<TABLE5527, bool>> predicate);
}
