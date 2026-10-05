using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE146;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE146Service : IService<TABLE146Dto, CreateTABLE146Dto, UpdateTABLE146Dto, int>
{
    Task<IEnumerable<TABLE146Dto>> FindAsync(Expression<Func<TABLE146, bool>> predicate);
}
