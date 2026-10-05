using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5601;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5601Service : IService<TABLE5601Dto, CreateTABLE5601Dto, UpdateTABLE5601Dto, int>
{
    Task<IEnumerable<TABLE5601Dto>> FindAsync(Expression<Func<TABLE5601, bool>> predicate);
}
