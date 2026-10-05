using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9028;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9028Service : IService<TABLE9028Dto, CreateTABLE9028Dto, UpdateTABLE9028Dto, int>
{
    Task<IEnumerable<TABLE9028Dto>> FindAsync(Expression<Func<TABLE9028, bool>> predicate);
}
