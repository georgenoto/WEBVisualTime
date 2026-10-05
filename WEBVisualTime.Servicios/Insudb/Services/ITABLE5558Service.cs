using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5558;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5558Service : IService<TABLE5558Dto, CreateTABLE5558Dto, UpdateTABLE5558Dto, int>
{
    Task<IEnumerable<TABLE5558Dto>> FindAsync(Expression<Func<TABLE5558, bool>> predicate);
}
