using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE511;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE511Service : IService<TABLE511Dto, CreateTABLE511Dto, UpdateTABLE511Dto, string>
{
    Task<IEnumerable<TABLE511Dto>> FindAsync(Expression<Func<TABLE511, bool>> predicate);
}
