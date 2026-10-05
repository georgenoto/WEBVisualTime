using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5554;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5554Service : IService<TABLE5554Dto, CreateTABLE5554Dto, UpdateTABLE5554Dto, int>
{
    Task<IEnumerable<TABLE5554Dto>> FindAsync(Expression<Func<TABLE5554, bool>> predicate);
}
