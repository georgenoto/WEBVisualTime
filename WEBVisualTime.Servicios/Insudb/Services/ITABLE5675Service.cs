using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5675;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5675Service : IService<TABLE5675Dto, CreateTABLE5675Dto, UpdateTABLE5675Dto, int>
{
    Task<IEnumerable<TABLE5675Dto>> FindAsync(Expression<Func<TABLE5675, bool>> predicate);
}
