using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5585;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5585Service : IService<TABLE5585Dto, CreateTABLE5585Dto, UpdateTABLE5585Dto, int>
{
    Task<IEnumerable<TABLE5585Dto>> FindAsync(Expression<Func<TABLE5585, bool>> predicate);
}
