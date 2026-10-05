using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5578;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5578Service : IService<TABLE5578Dto, CreateTABLE5578Dto, UpdateTABLE5578Dto, int>
{
    Task<IEnumerable<TABLE5578Dto>> FindAsync(Expression<Func<TABLE5578, bool>> predicate);
}
