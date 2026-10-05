using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5712;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5712Service : IService<TABLE5712Dto, CreateTABLE5712Dto, UpdateTABLE5712Dto, int>
{
    Task<IEnumerable<TABLE5712Dto>> FindAsync(Expression<Func<TABLE5712, bool>> predicate);
}
