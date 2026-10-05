using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9252;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9252Service : IService<TABLE9252Dto, CreateTABLE9252Dto, UpdateTABLE9252Dto, int>
{
    Task<IEnumerable<TABLE9252Dto>> FindAsync(Expression<Func<TABLE9252, bool>> predicate);
}
