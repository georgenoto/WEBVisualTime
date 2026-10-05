using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1009;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE1009Service : IService<TABLE1009Dto, CreateTABLE1009Dto, UpdateTABLE1009Dto, long>
{
    Task<IEnumerable<TABLE1009Dto>> FindAsync(Expression<Func<TABLE1009, bool>> predicate);
}
