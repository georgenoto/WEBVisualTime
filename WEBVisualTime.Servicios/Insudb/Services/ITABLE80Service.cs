using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE80;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE80Service : IService<TABLE80Dto, CreateTABLE80Dto, UpdateTABLE80Dto, string>
{
    Task<IEnumerable<TABLE80Dto>> FindAsync(Expression<Func<TABLE80, bool>> predicate);
}
