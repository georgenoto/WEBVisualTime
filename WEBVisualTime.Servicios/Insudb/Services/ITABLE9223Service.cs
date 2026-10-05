using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9223;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9223Service : IService<TABLE9223Dto, CreateTABLE9223Dto, UpdateTABLE9223Dto, int>
{
    Task<IEnumerable<TABLE9223Dto>> FindAsync(Expression<Func<TABLE9223, bool>> predicate);
}
