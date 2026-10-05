using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5662;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5662Service : IService<TABLE5662Dto, CreateTABLE5662Dto, UpdateTABLE5662Dto, int>
{
    Task<IEnumerable<TABLE5662Dto>> FindAsync(Expression<Func<TABLE5662, bool>> predicate);
}
