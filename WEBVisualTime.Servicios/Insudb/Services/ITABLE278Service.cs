using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE278;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE278Service : IService<TABLE278Dto, CreateTABLE278Dto, UpdateTABLE278Dto, int>
{
    Task<IEnumerable<TABLE278Dto>> FindAsync(Expression<Func<TABLE278, bool>> predicate);
}
