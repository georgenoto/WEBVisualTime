using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5563;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5563Service : IService<TABLE5563Dto, CreateTABLE5563Dto, UpdateTABLE5563Dto, int>
{
    Task<IEnumerable<TABLE5563Dto>> FindAsync(Expression<Func<TABLE5563, bool>> predicate);
}
