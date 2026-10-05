using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9260;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9260Service : IService<TABLE9260Dto, CreateTABLE9260Dto, UpdateTABLE9260Dto, int>
{
    Task<IEnumerable<TABLE9260Dto>> FindAsync(Expression<Func<TABLE9260, bool>> predicate);
}
