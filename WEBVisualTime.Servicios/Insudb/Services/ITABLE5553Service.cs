using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5553;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5553Service : IService<TABLE5553Dto, CreateTABLE5553Dto, UpdateTABLE5553Dto, int>
{
    Task<IEnumerable<TABLE5553Dto>> FindAsync(Expression<Func<TABLE5553, bool>> predicate);
}
