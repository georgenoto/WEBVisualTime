using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5534;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5534Service : IService<TABLE5534Dto, CreateTABLE5534Dto, UpdateTABLE5534Dto, int>
{
    Task<IEnumerable<TABLE5534Dto>> FindAsync(Expression<Func<TABLE5534, bool>> predicate);
}
