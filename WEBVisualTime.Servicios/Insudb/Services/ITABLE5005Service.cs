using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5005;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5005Service : IService<TABLE5005Dto, CreateTABLE5005Dto, UpdateTABLE5005Dto, int>
{
    Task<IEnumerable<TABLE5005Dto>> FindAsync(Expression<Func<TABLE5005, bool>> predicate);
}
