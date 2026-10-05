using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE61;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE61Service : IService<TABLE61Dto, CreateTABLE61Dto, UpdateTABLE61Dto, int>
{
    Task<IEnumerable<TABLE61Dto>> FindAsync(Expression<Func<TABLE61, bool>> predicate);
}
