using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5517;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5517Service : IService<TABLE5517Dto, CreateTABLE5517Dto, UpdateTABLE5517Dto, int>
{
    Task<IEnumerable<TABLE5517Dto>> FindAsync(Expression<Func<TABLE5517, bool>> predicate);
}
