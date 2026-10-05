using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5549;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5549Service : IService<TABLE5549Dto, CreateTABLE5549Dto, UpdateTABLE5549Dto, int>
{
    Task<IEnumerable<TABLE5549Dto>> FindAsync(Expression<Func<TABLE5549, bool>> predicate);
}
