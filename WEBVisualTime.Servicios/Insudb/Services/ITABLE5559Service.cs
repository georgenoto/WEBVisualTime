using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5559;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5559Service : IService<TABLE5559Dto, CreateTABLE5559Dto, UpdateTABLE5559Dto, int>
{
    Task<IEnumerable<TABLE5559Dto>> FindAsync(Expression<Func<TABLE5559, bool>> predicate);
}
