using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5002Service : IService<TABLE5002Dto, CreateTABLE5002Dto, UpdateTABLE5002Dto, int>
{
    Task<IEnumerable<TABLE5002Dto>> FindAsync(Expression<Func<TABLE5002, bool>> predicate);
}
