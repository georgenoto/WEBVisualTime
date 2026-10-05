using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE199;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE199Service : IService<TABLE199Dto, CreateTABLE199Dto, UpdateTABLE199Dto, int>
{
    Task<IEnumerable<TABLE199Dto>> FindAsync(Expression<Func<TABLE199, bool>> predicate);
}
