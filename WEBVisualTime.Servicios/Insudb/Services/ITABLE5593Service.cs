using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5593;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5593Service : IService<TABLE5593Dto, CreateTABLE5593Dto, UpdateTABLE5593Dto, int>
{
    Task<IEnumerable<TABLE5593Dto>> FindAsync(Expression<Func<TABLE5593, bool>> predicate);
}
