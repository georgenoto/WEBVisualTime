using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5587;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5587Service : IService<TABLE5587Dto, CreateTABLE5587Dto, UpdateTABLE5587Dto, int>
{
    Task<IEnumerable<TABLE5587Dto>> FindAsync(Expression<Func<TABLE5587, bool>> predicate);
}
