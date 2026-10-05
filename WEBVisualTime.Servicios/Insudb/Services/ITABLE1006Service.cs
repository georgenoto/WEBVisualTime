using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1006;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE1006Service : IService<TABLE1006Dto, CreateTABLE1006Dto, UpdateTABLE1006Dto, int>
{
    Task<IEnumerable<TABLE1006Dto>> FindAsync(Expression<Func<TABLE1006, bool>> predicate);
}
