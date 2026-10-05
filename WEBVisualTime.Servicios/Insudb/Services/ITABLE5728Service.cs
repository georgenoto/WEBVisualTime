using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5728;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5728Service : IService<TABLE5728Dto, CreateTABLE5728Dto, UpdateTABLE5728Dto, int>
{
    Task<IEnumerable<TABLE5728Dto>> FindAsync(Expression<Func<TABLE5728, bool>> predicate);
}
