using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5551;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5551Service : IService<TABLE5551Dto, CreateTABLE5551Dto, UpdateTABLE5551Dto, int>
{
    Task<IEnumerable<TABLE5551Dto>> FindAsync(Expression<Func<TABLE5551, bool>> predicate);
}
