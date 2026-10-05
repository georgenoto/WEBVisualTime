using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE160;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE160Service : IService<TABLE160Dto, CreateTABLE160Dto, UpdateTABLE160Dto, int>
{
    Task<IEnumerable<TABLE160Dto>> FindAsync(Expression<Func<TABLE160, bool>> predicate);
}
