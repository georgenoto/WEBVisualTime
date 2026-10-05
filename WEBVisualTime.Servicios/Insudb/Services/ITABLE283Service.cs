using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE283;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE283Service : IService<TABLE283Dto, CreateTABLE283Dto, UpdateTABLE283Dto, int>
{
    Task<IEnumerable<TABLE283Dto>> FindAsync(Expression<Func<TABLE283, bool>> predicate);
}
