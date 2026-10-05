using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5541;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5541Service : IService<TABLE5541Dto, CreateTABLE5541Dto, UpdateTABLE5541Dto, int>
{
    Task<IEnumerable<TABLE5541Dto>> FindAsync(Expression<Func<TABLE5541, bool>> predicate);
}
