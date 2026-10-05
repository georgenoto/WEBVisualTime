using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5672;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5672Service : IService<TABLE5672Dto, CreateTABLE5672Dto, UpdateTABLE5672Dto, int>
{
    Task<IEnumerable<TABLE5672Dto>> FindAsync(Expression<Func<TABLE5672, bool>> predicate);
}
