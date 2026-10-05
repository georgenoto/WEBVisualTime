using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5521;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5521Service : IService<TABLE5521Dto, CreateTABLE5521Dto, UpdateTABLE5521Dto, int>
{
    Task<IEnumerable<TABLE5521Dto>> FindAsync(Expression<Func<TABLE5521, bool>> predicate);
}
