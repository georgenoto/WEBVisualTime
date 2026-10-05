using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5565;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5565Service : IService<TABLE5565Dto, CreateTABLE5565Dto, UpdateTABLE5565Dto, int>
{
    Task<IEnumerable<TABLE5565Dto>> FindAsync(Expression<Func<TABLE5565, bool>> predicate);
}
