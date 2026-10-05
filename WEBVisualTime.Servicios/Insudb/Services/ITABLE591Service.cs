using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE591;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE591Service : IService<TABLE591Dto, CreateTABLE591Dto, UpdateTABLE591Dto, int>
{
    Task<IEnumerable<TABLE591Dto>> FindAsync(Expression<Func<TABLE591, bool>> predicate);
}
