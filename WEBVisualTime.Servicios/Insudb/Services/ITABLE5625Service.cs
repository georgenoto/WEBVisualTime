using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5625;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5625Service : IService<TABLE5625Dto, CreateTABLE5625Dto, UpdateTABLE5625Dto, int>
{
    Task<IEnumerable<TABLE5625Dto>> FindAsync(Expression<Func<TABLE5625, bool>> predicate);
}
