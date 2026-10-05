using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5575;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5575Service : IService<TABLE5575Dto, CreateTABLE5575Dto, UpdateTABLE5575Dto, int>
{
    Task<IEnumerable<TABLE5575Dto>> FindAsync(Expression<Func<TABLE5575, bool>> predicate);
}
