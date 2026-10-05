using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9031;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9031Service : IService<TABLE9031Dto, CreateTABLE9031Dto, UpdateTABLE9031Dto, int>
{
    Task<IEnumerable<TABLE9031Dto>> FindAsync(Expression<Func<TABLE9031, bool>> predicate);
}
