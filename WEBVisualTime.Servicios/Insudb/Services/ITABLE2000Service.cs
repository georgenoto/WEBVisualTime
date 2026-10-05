using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2000;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE2000Service : IService<TABLE2000Dto, CreateTABLE2000Dto, UpdateTABLE2000Dto, long>
{
    Task<IEnumerable<TABLE2000Dto>> FindAsync(Expression<Func<TABLE2000, bool>> predicate);
}
