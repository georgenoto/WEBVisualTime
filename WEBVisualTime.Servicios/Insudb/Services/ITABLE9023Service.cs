using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9023;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9023Service : IService<TABLE9023Dto, CreateTABLE9023Dto, UpdateTABLE9023Dto, int>
{
    Task<IEnumerable<TABLE9023Dto>> FindAsync(Expression<Func<TABLE9023, bool>> predicate);
}
