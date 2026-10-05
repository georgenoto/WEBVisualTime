using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5555Service : IService<TABLE5555Dto, CreateTABLE5555Dto, UpdateTABLE5555Dto, int>
{
    Task<IEnumerable<TABLE5555Dto>> FindAsync(Expression<Func<TABLE5555, bool>> predicate);
}
