using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9220;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9220Service : IService<TABLE9220Dto, CreateTABLE9220Dto, UpdateTABLE9220Dto, int>
{
    Task<IEnumerable<TABLE9220Dto>> FindAsync(Expression<Func<TABLE9220, bool>> predicate);
}
