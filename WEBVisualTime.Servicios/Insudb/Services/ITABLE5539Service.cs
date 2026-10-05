using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5539;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5539Service : IService<TABLE5539Dto, CreateTABLE5539Dto, UpdateTABLE5539Dto, int>
{
    Task<IEnumerable<TABLE5539Dto>> FindAsync(Expression<Func<TABLE5539, bool>> predicate);
}
