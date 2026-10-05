using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5009;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5009Service : IService<TABLE5009Dto, CreateTABLE5009Dto, UpdateTABLE5009Dto, int>
{
    Task<IEnumerable<TABLE5009Dto>> FindAsync(Expression<Func<TABLE5009, bool>> predicate);
}
