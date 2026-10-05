using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5571;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5571Service : IService<TABLE5571Dto, CreateTABLE5571Dto, UpdateTABLE5571Dto, int>
{
    Task<IEnumerable<TABLE5571Dto>> FindAsync(Expression<Func<TABLE5571, bool>> predicate);
}
