using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE282;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE282Service : IService<TABLE282Dto, CreateTABLE282Dto, UpdateTABLE282Dto, int>
{
    Task<IEnumerable<TABLE282Dto>> FindAsync(Expression<Func<TABLE282, bool>> predicate);
}
