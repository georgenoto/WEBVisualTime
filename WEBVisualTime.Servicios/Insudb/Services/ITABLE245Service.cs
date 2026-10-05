using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE245;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE245Service : IService<TABLE245Dto, CreateTABLE245Dto, UpdateTABLE245Dto, long>
{
    Task<IEnumerable<TABLE245Dto>> FindAsync(Expression<Func<TABLE245, bool>> predicate);
}
