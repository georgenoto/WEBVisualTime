using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAUSE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAUSEService : IService<CLAUSEDto, CreateCLAUSEDto, UpdateCLAUSEDto, string>
{
    Task<IEnumerable<CLAUSEDto>> FindAsync(Expression<Func<CLAUSE, bool>> predicate);
}
