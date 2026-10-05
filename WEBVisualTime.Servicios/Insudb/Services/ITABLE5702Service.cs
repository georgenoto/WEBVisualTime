using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5702;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5702Service : IService<TABLE5702Dto, CreateTABLE5702Dto, UpdateTABLE5702Dto, int>
{
    Task<IEnumerable<TABLE5702Dto>> FindAsync(Expression<Func<TABLE5702, bool>> predicate);
}
