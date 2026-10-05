using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE133;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE133Service : IService<TABLE133Dto, CreateTABLE133Dto, UpdateTABLE133Dto, int>
{
    Task<IEnumerable<TABLE133Dto>> FindAsync(Expression<Func<TABLE133, bool>> predicate);
}
