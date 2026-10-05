using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5610;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5610Service : IService<TABLE5610Dto, CreateTABLE5610Dto, UpdateTABLE5610Dto, int>
{
    Task<IEnumerable<TABLE5610Dto>> FindAsync(Expression<Func<TABLE5610, bool>> predicate);
}
