using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE634;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE634Service : IService<TABLE634Dto, CreateTABLE634Dto, UpdateTABLE634Dto, int>
{
    Task<IEnumerable<TABLE634Dto>> FindAsync(Expression<Func<TABLE634, bool>> predicate);
}
