using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9011;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9011Service : IService<TABLE9011Dto, CreateTABLE9011Dto, UpdateTABLE9011Dto, int>
{
    Task<IEnumerable<TABLE9011Dto>> FindAsync(Expression<Func<TABLE9011, bool>> predicate);
}
