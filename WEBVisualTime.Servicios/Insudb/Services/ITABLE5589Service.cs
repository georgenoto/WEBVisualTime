using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5589Service : IService<TABLE5589Dto, CreateTABLE5589Dto, UpdateTABLE5589Dto, int>
{
    Task<IEnumerable<TABLE5589Dto>> FindAsync(Expression<Func<TABLE5589, bool>> predicate);
}
