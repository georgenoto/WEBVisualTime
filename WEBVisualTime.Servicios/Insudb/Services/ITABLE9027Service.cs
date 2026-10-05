using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9027;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9027Service : IService<TABLE9027Dto, CreateTABLE9027Dto, UpdateTABLE9027Dto, int>
{
    Task<IEnumerable<TABLE9027Dto>> FindAsync(Expression<Func<TABLE9027, bool>> predicate);
}
