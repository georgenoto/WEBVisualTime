using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE695;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE695Service : IService<TABLE695Dto, CreateTABLE695Dto, UpdateTABLE695Dto, int>
{
    Task<IEnumerable<TABLE695Dto>> FindAsync(Expression<Func<TABLE695, bool>> predicate);
}
