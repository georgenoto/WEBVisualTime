using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE340;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE340Service : IService<TABLE340Dto, CreateTABLE340Dto, UpdateTABLE340Dto, int>
{
    Task<IEnumerable<TABLE340Dto>> FindAsync(Expression<Func<TABLE340, bool>> predicate);
}
