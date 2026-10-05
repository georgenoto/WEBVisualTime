using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE195;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE195Service : IService<TABLE195Dto, CreateTABLE195Dto, UpdateTABLE195Dto, long>
{
    Task<IEnumerable<TABLE195Dto>> FindAsync(Expression<Func<TABLE195, bool>> predicate);
}
