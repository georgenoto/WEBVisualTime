using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5603;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5603Service : IService<TABLE5603Dto, CreateTABLE5603Dto, UpdateTABLE5603Dto, int>
{
    Task<IEnumerable<TABLE5603Dto>> FindAsync(Expression<Func<TABLE5603, bool>> predicate);
}
