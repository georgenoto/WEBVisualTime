using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE2Service : IService<TABLE2Dto, CreateTABLE2Dto, UpdateTABLE2Dto, long>
{
    Task<IEnumerable<TABLE2Dto>> FindAsync(Expression<Func<TABLE2, bool>> predicate);
}
