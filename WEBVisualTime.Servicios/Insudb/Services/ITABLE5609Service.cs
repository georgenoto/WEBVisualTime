using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5609;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5609Service : IService<TABLE5609Dto, CreateTABLE5609Dto, UpdateTABLE5609Dto, int>
{
    Task<IEnumerable<TABLE5609Dto>> FindAsync(Expression<Func<TABLE5609, bool>> predicate);
}
