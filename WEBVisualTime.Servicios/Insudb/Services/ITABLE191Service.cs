using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE191;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE191Service : IService<TABLE191Dto, CreateTABLE191Dto, UpdateTABLE191Dto, string>
{
    Task<IEnumerable<TABLE191Dto>> FindAsync(Expression<Func<TABLE191, bool>> predicate);
}
