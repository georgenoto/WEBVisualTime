using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9281;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9281Service : IService<TABLE9281Dto, CreateTABLE9281Dto, UpdateTABLE9281Dto, int>
{
    Task<IEnumerable<TABLE9281Dto>> FindAsync(Expression<Func<TABLE9281, bool>> predicate);
}
