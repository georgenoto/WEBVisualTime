using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9001;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9001Service : IService<TABLE9001Dto, CreateTABLE9001Dto, UpdateTABLE9001Dto, int>
{
    Task<IEnumerable<TABLE9001Dto>> FindAsync(Expression<Func<TABLE9001, bool>> predicate);
}
