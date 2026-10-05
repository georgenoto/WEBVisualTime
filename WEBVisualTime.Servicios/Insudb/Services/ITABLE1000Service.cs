using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1000;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE1000Service : IService<TABLE1000Dto, CreateTABLE1000Dto, UpdateTABLE1000Dto, int>
{
    Task<IEnumerable<TABLE1000Dto>> FindAsync(Expression<Func<TABLE1000, bool>> predicate);
}
