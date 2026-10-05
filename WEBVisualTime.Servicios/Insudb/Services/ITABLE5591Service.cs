using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5591;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5591Service : IService<TABLE5591Dto, CreateTABLE5591Dto, UpdateTABLE5591Dto, int>
{
    Task<IEnumerable<TABLE5591Dto>> FindAsync(Expression<Func<TABLE5591, bool>> predicate);
}
