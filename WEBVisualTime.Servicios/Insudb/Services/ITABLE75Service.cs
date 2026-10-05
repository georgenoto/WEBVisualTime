using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE75Service : IService<TABLE75Dto, CreateTABLE75Dto, UpdateTABLE75Dto, int>
{
    Task<IEnumerable<TABLE75Dto>> FindAsync(Expression<Func<TABLE75, bool>> predicate);
}
