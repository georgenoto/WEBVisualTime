using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5523;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5523Service : IService<TABLE5523Dto, CreateTABLE5523Dto, UpdateTABLE5523Dto, int>
{
    Task<IEnumerable<TABLE5523Dto>> FindAsync(Expression<Func<TABLE5523, bool>> predicate);
}
