using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5634;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5634Service : IService<TABLE5634Dto, CreateTABLE5634Dto, UpdateTABLE5634Dto, int>
{
    Task<IEnumerable<TABLE5634Dto>> FindAsync(Expression<Func<TABLE5634, bool>> predicate);
}
