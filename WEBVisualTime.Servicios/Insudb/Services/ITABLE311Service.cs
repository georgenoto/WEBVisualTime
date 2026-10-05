using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE311;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE311Service : IService<TABLE311Dto, CreateTABLE311Dto, UpdateTABLE311Dto, int>
{
    Task<IEnumerable<TABLE311Dto>> FindAsync(Expression<Func<TABLE311, bool>> predicate);
}
