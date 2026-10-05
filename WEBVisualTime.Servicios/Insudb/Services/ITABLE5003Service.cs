using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5003;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5003Service : IService<TABLE5003Dto, CreateTABLE5003Dto, UpdateTABLE5003Dto, int>
{
    Task<IEnumerable<TABLE5003Dto>> FindAsync(Expression<Func<TABLE5003, bool>> predicate);
}
