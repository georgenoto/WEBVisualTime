using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5501;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5501Service : IService<TABLE5501Dto, CreateTABLE5501Dto, UpdateTABLE5501Dto, int>
{
    Task<IEnumerable<TABLE5501Dto>> FindAsync(Expression<Func<TABLE5501, bool>> predicate);
}
