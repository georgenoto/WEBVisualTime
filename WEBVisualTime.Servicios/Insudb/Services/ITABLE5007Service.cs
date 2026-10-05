using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5007;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5007Service : IService<TABLE5007Dto, CreateTABLE5007Dto, UpdateTABLE5007Dto, string>
{
    Task<IEnumerable<TABLE5007Dto>> FindAsync(Expression<Func<TABLE5007, bool>> predicate);
}
