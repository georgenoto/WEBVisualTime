using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5719;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5719Service : IService<TABLE5719Dto, CreateTABLE5719Dto, UpdateTABLE5719Dto, int>
{
    Task<IEnumerable<TABLE5719Dto>> FindAsync(Expression<Func<TABLE5719, bool>> predicate);
}
