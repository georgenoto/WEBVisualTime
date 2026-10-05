using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5536;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5536Service : IService<TABLE5536Dto, CreateTABLE5536Dto, UpdateTABLE5536Dto, int>
{
    Task<IEnumerable<TABLE5536Dto>> FindAsync(Expression<Func<TABLE5536, bool>> predicate);
}
