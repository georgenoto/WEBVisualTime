using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE333;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE333Service : IService<TABLE333Dto, CreateTABLE333Dto, UpdateTABLE333Dto, int>
{
    Task<IEnumerable<TABLE333Dto>> FindAsync(Expression<Func<TABLE333, bool>> predicate);
}
