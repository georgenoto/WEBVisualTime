using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5500;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5500Service : IService<TABLE5500Dto, CreateTABLE5500Dto, UpdateTABLE5500Dto, int>
{
    Task<IEnumerable<TABLE5500Dto>> FindAsync(Expression<Func<TABLE5500, bool>> predicate);
}
